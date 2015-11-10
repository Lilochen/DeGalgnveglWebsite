<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="utf-8">
    <title>
        @ViewBag.Message;
    </title>
</head>
<body>
    @section featured {
        <section class="featured">
            <div class="content-wrapper">
                <hgroup class="title">
                    <h1>@ViewBag.Message</h1>
                </hgroup>
                <p>
                    <?php
						$name 	= $_REQUEST ['Name'];
						$mail 	= $_REQUEST ['Email'];
						$telefon 	= $_REQUEST ['Telefon'];
						$betreff 	= $_REQUEST ['Betreff'];
						$nachricht 	= $_REQUEST ['Nachricht'];
						
						$empfaenger ="kristinstopp@googlemail.com";
						$absender	=$mail;
						
						//Pflichtfelder
						$fehler = false; 

						if (empty($name)) 
						{ 
							$fehler .= "<p class=\"normal\"><b>Fehler!</b><br>Bitte vergessen Sie nicht Ihren <B>Namen</b> anzugeben!</b><br>"; 
						} 
						if ($empty($mail)) 
						{
							$fehler .= "<p class=\"normal\"><b>Fehler!</b><br>Bitte vergessen Sie nicht Ihre <B>EMail-Adresse</b> anzugeben!</b><br>"; 
						} 
						if ($empty($telefon)) 
						{
							$fehler .= "<p class=\"normal\"><b>Fehler!</b><br>Bitte vergessen Sie nicht Ihre <B>Telefon Nummer</b> anzugeben!</b><br>"; 
						} 
						if ($empty($betreff)) 
						{
							$fehler .= "<p class=\"normal\"><b>Fehler!</b><br>Bitte vergessen Sie nicht Ihren <B>Betreff</b> anzugeben!</b><br>"; 
						} 
						if ($empty($nachricht)) 
						{
							$fehler .= "<p class=\"normal\"><b>Fehler!</b><br>Bitte vergessen Sie nicht Ihre <B>Nachricht</b> anzugeben!</b><br>"; 
						} 
						if ($fehler) { 
							echo $fehler; 
						}  
						
						$betreffwebmaster	="Kontaktanfrage ($name)";
						$koerperwebmaster	="$name hat Kontaktanfrage gestellt".
						"\n\n
						Kontaktdaten: \n
						\t Name: 	$name \n
						\t Email:	$mail \n
						\t Telefon:	$telefon \n
						\t Betreff: $betreff \n
						\n\n".
						$nachricht;
						
						$betreffkunde	="Ihre Kontaktanfrage bei ...";
						$koerperkunde	="Sie ($name) haben folgende Kontaktanfrage gestellt ".
						"\n\n
						Kontaktdaten: \n
						\t Name: 	$name \n
						\t Email:	$mail \n
						\t Telefon:	$telefon \n
						\t Betreff: $betreff \n
						\n\n".
						$nachricht;
						
						$abgesandt = "<p>Vielen Dank für Ihre Anfrage, Wir werden uns in Kürze bei Ihnen melden. </p>"
								
						mail("$empfaenger", "$betreffwebmaster", "$koerperwebmaster\n", "FORM: $absender\n");
						mail("$mail", "$betreffkunde", "$koerperkunde\n", "FORM: $absender\n");
						echo $abgesandt;
                    ?>
                </p>
            </div>
        </section>
    }
</body>
</html>
