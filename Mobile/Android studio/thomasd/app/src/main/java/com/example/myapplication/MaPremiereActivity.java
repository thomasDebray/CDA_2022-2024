package com.example.myapplication;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.res.Configuration;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

public class MaPremiereActivity extends AppCompatActivity {

    TextView texteCompteur;

    public final String KEY_MONAGE="monage";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        if(this.getResources().getConfiguration().orientation == Configuration.ORIENTATION_PORTRAIT){
            setContentView(R.layout.activity_ma_premiere);
        }
        if(this.getResources().getConfiguration().orientation == Configuration.ORIENTATION_LANDSCAPE){
            setContentView(R.layout.activity_ma_premiere);
        }
        texteCompteur = (TextView) findViewById(R.id.compteur);
        if(savedInstanceState!=null){
            int v = savedInstanceState.getInt(KEY_MONAGE);
            texteCompteur.setText(String.valueOf(v));
        }

    }

    //@Override
    //protected void onStart() {
    //    super.onStart();
    //}


    public void augmenterDe1(View v){
        int valeur = Integer.parseInt(texteCompteur.getText().toString());
        valeur++;
        texteCompteur.setText(String.valueOf(valeur));
    }

    public void diminuerDe1(View v){
        int valeur = Integer.parseInt(texteCompteur.getText().toString());
        valeur--;
        texteCompteur.setText(String.valueOf(valeur));
    }

    public void quit(View v){
        this.finish();
    }

    @Override
    protected void onSaveInstanceState(@NonNull Bundle outState) {
        super.onSaveInstanceState(outState);
        outState.putInt(KEY_MONAGE,Integer.parseInt(texteCompteur.getText().toString()));
    }
}