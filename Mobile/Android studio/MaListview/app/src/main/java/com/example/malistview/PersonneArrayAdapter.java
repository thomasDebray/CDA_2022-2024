package com.example.malistview;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.lang.reflect.Array;
import java.util.List;

public class PersonneArrayAdapter extends ArrayAdapter<Personne> {
    private List<Personne> listPersonnes;

    public PersonneArrayAdapter(Context context, List<Personne> personnes) {
        super(context,R.layout.mapetitelayout,personnes);
        listPersonnes=personnes;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup){
        if (view == null){
            LayoutInflater inflater = (LayoutInflater) getContext().getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            view= inflater.inflate(R.layout.mapetitelayout, null);
        }

        Personne personneOfItem = (Personne) listPersonnes.get(i);

        if(personneOfItem != null) {
            TextView nomView = (TextView) view.findViewById(R.id.textViewNom);
            TextView prenomView = (TextView) view.findViewById(R.id.textViewPrenom);

            if(nomView != null) {
                nomView.setText("Nom : " + personneOfItem.getNom());
            }
            if(prenomView != null) {
                prenomView.setText("Prénom : " + personneOfItem.getPrenom());
            }
        }
        return view;
    }
}
