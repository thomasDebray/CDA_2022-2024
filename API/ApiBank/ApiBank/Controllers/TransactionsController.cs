using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibraryDb;
using ClassLibraryModels;

namespace ApiBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly BankDbContext _context;

        public TransactionsController()
        {
            _context = new BankDbContext();
        }

        // GET: api/Transactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankTransaction>>> GetBankTransactions()
        {
          if (_context.BankTransactions == null)
          {
              return NotFound();
          }
            return await _context.BankTransactions.ToListAsync();
        }

        // GET: api/Transactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BankTransaction>> GetBankTransaction(int id)
        {
          if (_context.BankTransactions == null)
          {
              return NotFound();
          }
            var bankTransaction = await _context.BankTransactions.FindAsync(id);

            if (bankTransaction == null)
            {
                return NotFound();
            }

            return bankTransaction;
        }

        // PUT: api/Transactions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBankTransaction(int id, BankTransaction bankTransaction)
        {
            if (id != bankTransaction.Transaction_Id)
            {
                return BadRequest();
            }

            _context.Entry(bankTransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankTransactionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Transactions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BankTransaction>> PostBankTransaction(BankTransaction bankTransaction)
        {
          if (_context.BankTransactions == null)
          {
              return Problem("Entity set 'BankDbContext.BankTransactions'  is null.");
          }
            _context.BankTransactions.Add(bankTransaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBankTransaction", new { id = bankTransaction.Transaction_Id }, bankTransaction);
        }

        // DELETE: api/Transactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBankTransaction(int id)
        {
            if (_context.BankTransactions == null)
            {
                return NotFound();
            }
            var bankTransaction = await _context.BankTransactions.FindAsync(id);
            if (bankTransaction == null)
            {
                return NotFound();
            }

            _context.BankTransactions.Remove(bankTransaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BankTransactionExists(int id)
        {
            return (_context.BankTransactions?.Any(e => e.Transaction_Id == id)).GetValueOrDefault();
        }
    }
}
