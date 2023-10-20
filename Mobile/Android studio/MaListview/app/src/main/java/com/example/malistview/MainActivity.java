package com.example.malistview;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    ListView listView;
    List personnes;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        listView = ((ListView)findViewById(R.id.maList));
        //String[] tab = new String[]{"membre1","membre2","membre3"};
        //ArrayAdapter arrayadp = new ArrayAdapter(this, android.R.layout.simple_list_item_1,tab);
        //listView.setAdapter(arrayadp);

        personnes = new ArrayList<Personne>();
        personnes.add(new Personne("Bidule","Chouette"));
        personnes.add(new Personne("Truc","Chose"));
        personnes.add(new Personne("Plif","Plouf"));

        //ArrayAdapter<Personne> arrayadb = new PersonneArrayAdapter(this,personnes);
        listView.setAdapter(new PersonneArrayAdapter(this,personnes));

        registerForContextMenu(listView);

    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);

        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu_listview_personne, menu);
    }

    private static final int COPIE = R.id.copie;
    private static final int DELETE = R.id.delete;
    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
        AdapterView.AdapterContextMenuInfo menuInfo = (AdapterView.AdapterContextMenuInfo)item.getMenuInfo();
        if (item.getItemId() == COPIE) {
            Toast.makeText(getApplicationContext(), "Copie: ID " + menuInfo.id + ", position " + menuInfo.position, Toast.LENGTH_SHORT).show();
            PersonneArrayAdapter pas=(PersonneArrayAdapter)listView.getAdapter();
            Personne pACopie = pas.getItem(menuInfo.position);
            pas.add(pACopie);
            pas.notifyDataSetChanged();
        } else if (item.getItemId() == DELETE) {
            Toast.makeText(getApplicationContext(), "Delete: ID " + menuInfo.id + ", position " + menuInfo.position, Toast.LENGTH_SHORT).show();
            PersonneArrayAdapter pas=(PersonneArrayAdapter)listView.getAdapter();
            Personne pASupprimer = pas.getItem(menuInfo.position);
            pas.remove(pASupprimer);
            pas.notifyDataSetChanged();
        }
        return true;
    }

    public void Ajout(View v) {
        Intent intent = new Intent(this, MainActivityAjout.class);
        startActivityForResult(intent,1);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if(resultCode==RESULT_OK&&requestCode==1){
            Personne nouvellePersonne = new Personne(data.getStringExtra("nom"),data.getStringExtra("prenom"));
            personnes.add(nouvellePersonne);
            ((ArrayAdapter)listView.getAdapter()).notifyDataSetChanged();
        }
    }
}