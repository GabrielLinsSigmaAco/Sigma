# GitHub Update Server - Controle de Transportes

## Estrutura

Coloque estes arquivos em Releases do GitHub:

- app.enc
- app.sig
- icon.ico

## Uso

Seu sistema vai consumir o manifest.json:

```
https://raw.githubusercontent.com/SEU_USUARIO/SEU_REPO/main/manifest.json
```

ou você pode hospedar o manifest também em release.

## Fluxo

EXE -> baixa manifest.json  
EXE -> baixa app.enc  
EXE -> baixa app.sig  
EXE -> baixa icon.ico  

## Substitua:
SEU_USUARIO / SEU_REPO
