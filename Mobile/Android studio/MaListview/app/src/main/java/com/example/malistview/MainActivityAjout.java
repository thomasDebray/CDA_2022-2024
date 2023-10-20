package com.example.malistview;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class MainActivityAjout extends AppCompatActivity {

    private EditText editTextNom;
    private EditText editTextPrenom;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_ajout);
        editTextNom=(EditText)findViewById(R.id.editTextNom);
        editTextPrenom=(EditText)findViewById(R.id.editTextTextPrenom);
    }

    public void Valider(View v){
        Intent i = this.getIntent();
        //i.putExtra()
        String textNom =editTextNom.getText().toString();
        String textPrenom=editTextPrenom.getText().toString();
        i.putExtra("nom",textNom);
        i.putExtra("prenom",textPrenom);
        setResult(Activity.RESULT_OK,i);
        this.finish();
    }
}