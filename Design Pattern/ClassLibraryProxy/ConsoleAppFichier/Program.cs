using ClassLibraryProxy;

// Client -> FichierProxy -> FichierSource

FichierProxy fichierProxy = new FichierProxy("bob");

fichierProxy.Lire();
fichierProxy.Ecrire();
