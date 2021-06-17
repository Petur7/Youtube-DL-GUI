#include <fstream>
#include <iostream>

using namespace std;

string execute(const std::string& command) {

    system((command + " > temp.txt").c_str());
 
    std::ifstream ifs("temp.txt");
    std::string ret{ istreambuf_iterator<char>(ifs), istreambuf_iterator<char>() };
    ifs.close();
    if (std::remove("temp.txt") != 0) {
        perror("Error deleting temporary file");
    }
    return ret;
}

int main(int argc, char** argv) {
    if (argc < 3) return 1;

    string videoURL = argv[1];
    string outputLocation = argv[2];
    string YoutubeDLArgument = argv[3];

    string argument = "youtube-dl " + YoutubeDLArgument + " " + videoURL;
    string videoInfo = execute(argument);

    ofstream outputFile(outputLocation);
    outputFile << videoInfo;
    outputFile.close();

    return 0;
}