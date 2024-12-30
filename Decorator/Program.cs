using Decorator.Solution;

string url = "https.google.cloud.com";
string data = "This is some random data";

bool comppres = true;
bool encrypt = true;

IData cloudData = new CloudData(url);

if (encrypt)
{
    cloudData = new EncryptionDecorator(cloudData);
}

if (comppres)
{
    cloudData = new CompressionDecorator(cloudData);
}

cloudData.Save(data);