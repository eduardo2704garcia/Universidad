using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;

public class GeometricFigure
{
    private float mSize;
    private Graphics mGraph;
    private const float SF = 1.0f;  // Scale factor
    private Pen mPen;

    public GeometricFigure()
    {
        mSize = 0.0f;
    }

    public void ReadData(TextBox txtSize)
    {
        try
        {
            mSize = float.Parse(txtSize.Text);
        }
        catch
        {
            MessageBox.Show("Ingreso invalido...", "Mensaje de error");
        }
    }

    public void InitializeData(TextBox txtSize, PictureBox picCanvas)
    {
        mSize = 0.0f;
        txtSize.Text = "";
        txtSize.Focus();
        picCanvas.Refresh();
    }

    public void PlotShape(PictureBox picCanvas)
    {
        mGraph = picCanvas.CreateGraphics();
        mGraph.SmoothingMode = SmoothingMode.AntiAlias;
        mPen = new Pen(Color.Blue, 2);

        // Centro del PictureBox
        float centerX = picCanvas.Width / 2f;
        float centerY = picCanvas.Height / 2f;

        // Radio base escalado por el tamaño ingresado
        float radio = mSize * SF;

        // Dibujar la figura completa
        DibujarFiguraCompleja(centerX, centerY, radio);

        mPen.Dispose();
        mGraph.Dispose();
    }

    private void DibujarFiguraCompleja(float centerX, float centerY, float radio)
    {
        // Dibujar hexágonos exteriores
        DibujarHexagonosExteriores(centerX, centerY, radio);

        // Dibujar estrella de David central
        DibujarEstrellaDeDate(centerX, centerY, radio * 0.6f);

        // Dibujar líneas de conexión adicionales
        DibujarLineasConexion(centerX, centerY, radio);
    }

    private void DibujarHexagonosExteriores(float centerX, float centerY, float radio)
    {
        // Hexágono central grande
        PointF[] hexagonoCentral = CrearHexagono(centerX, centerY, radio);
        //mGraph.DrawPolygon(mPen, hexagonoCentral); -------1

        // Hexágonos más pequeños alrededor
        float radioMenor = radio * 0.4f;
        float distancia = radio * 0.8f;

        for (int i = 0; i < 6; i++)
        {
            double angulo = i * Math.PI / 3; // 60 grados
            float x = centerX + (float)(distancia * Math.Cos(angulo));
            float y = centerY + (float)(distancia * Math.Sin(angulo));

            PointF[] hexagonoPequeño = CrearHexagono(x, y, radioMenor);
            mGraph.DrawPolygon(mPen, hexagonoPequeño);
        }

        // Hexágonos en las esquinas (más pequeños)
        float radioEsquina = radio * 0.25f;
        float distanciaEsquina = radio * 1.3f;

        for (int i = 0; i < 6; i++)
        {
            double angulo = i * Math.PI / 3 + Math.PI / 6; // Offset de 30 grados
            float x = centerX + (float)(distanciaEsquina * Math.Cos(angulo));
            float y = centerY + (float)(distanciaEsquina * Math.Sin(angulo));

            PointF[] hexagonoEsquina = CrearHexagono(x, y, radioEsquina);
            //mGraph.DrawPolygon(mPen, hexagonoEsquina); ------2
        }
    }

    private void DibujarEstrellaDeDate(float centerX, float centerY, float radio)
    {
        // Triángulo superior
        PointF[] triangulo1 = new PointF[3];
        triangulo1[0] = new PointF(centerX, centerY - radio);
        triangulo1[1] = new PointF(centerX - radio * 0.866f, centerY + radio * 0.5f);
        triangulo1[2] = new PointF(centerX + radio * 0.866f, centerY + radio * 0.5f);
        mGraph.DrawPolygon(mPen, triangulo1);

        // Triángulo inferior (invertido)
        PointF[] triangulo2 = new PointF[3];
        triangulo2[0] = new PointF(centerX, centerY + radio);
        triangulo2[1] = new PointF(centerX - radio * 0.866f, centerY - radio * 0.5f);
        triangulo2[2] = new PointF(centerX + radio * 0.866f, centerY - radio * 0.5f);
        mGraph.DrawPolygon(mPen, triangulo2);
    }

    private void DibujarLineasConexion(float centerX, float centerY, float radio)
    {
        // Líneas que conectan los hexágonos exteriores con el centro
        float distancia = radio * 0.8f;

        for (int i = 0; i < 6; i++)
        {
            double angulo = i * Math.PI / 3;
            float x1 = centerX + (float)(radio * 0.6f * Math.Cos(angulo));
            float y1 = centerY + (float)(radio * 0.6f * Math.Sin(angulo));
            float x2 = centerX + (float)(distancia * Math.Cos(angulo));
            float y2 = centerY + (float)(distancia * Math.Sin(angulo));

            //mGraph.DrawLine(mPen, x1, y1, x2, y2);--------3
        }

        // Líneas diagonales adicionales para crear el patrón complejo
        DibujarLineasDiagonales(centerX, centerY, radio);
    }

    private void DibujarLineasDiagonales(float centerX, float centerY, float radio)
    {
        float altura = radio * 0.3f;

        // Rombos verticales (superior e inferior)
        PointF[] romboSup = new PointF[4];
        romboSup[0] = new PointF(centerX, centerY - radio * 1.4f);
        romboSup[1] = new PointF(centerX - altura * 0.7f, centerY - radio * 1.05f);
        romboSup[2] = new PointF(centerX, centerY - radio * 0.7f);
        romboSup[3] = new PointF(centerX + altura * 0.7f, centerY - radio * 1.05f);
        mGraph.DrawPolygon(mPen, romboSup);

        PointF[] romboInf = new PointF[4];
        romboInf[0] = new PointF(centerX, centerY + radio * 1.4f);
        romboInf[1] = new PointF(centerX - altura * 0.7f, centerY + radio * 1.05f);
        romboInf[2] = new PointF(centerX, centerY + radio * 0.7f);
        romboInf[3] = new PointF(centerX + altura * 0.7f, centerY + radio * 1.05f);
        mGraph.DrawPolygon(mPen, romboInf);

        // Rombos diagonales

        // Superior izquierda
        PointF[] romboSupIzq = new PointF[4];
        romboSupIzq[0] = new PointF(centerX - radio * 1.2f, centerY - radio * 1.2f);
        romboSupIzq[1] = new PointF(centerX - radio * 0.95f, centerY - radio * 0.9f);
        romboSupIzq[2] = new PointF(centerX - radio * 0.7f, centerY - radio * 0.7f);
        romboSupIzq[3] = new PointF(centerX - radio * 0.9f, centerY - radio * 0.95f);
        mGraph.DrawPolygon(mPen, romboSupIzq);

        // Superior derecha
        PointF[] romboSupDer = new PointF[4];
        romboSupDer[0] = new PointF(centerX + radio * 1.2f, centerY - radio * 1.2f);
        romboSupDer[1] = new PointF(centerX + radio * 0.95f, centerY - radio * 0.9f);
        romboSupDer[2] = new PointF(centerX + radio * 0.7f, centerY - radio * 0.7f);
        romboSupDer[3] = new PointF(centerX + radio * 0.9f, centerY - radio * 0.95f);
        mGraph.DrawPolygon(mPen, romboSupDer);

        // Inferior izquierda
        PointF[] romboInfIzq = new PointF[4];
        romboInfIzq[0] = new PointF(centerX - radio * 1.2f, centerY + radio * 1.2f);
        romboInfIzq[1] = new PointF(centerX - radio * 0.95f, centerY + radio * 0.9f);
        romboInfIzq[2] = new PointF(centerX - radio * 0.7f, centerY + radio * 0.7f);
        romboInfIzq[3] = new PointF(centerX - radio * 0.9f, centerY + radio * 0.95f);
        mGraph.DrawPolygon(mPen, romboInfIzq);

        // Inferior derecha
        PointF[] romboInfDer = new PointF[4];
        romboInfDer[0] = new PointF(centerX + radio * 1.2f, centerY + radio * 1.2f);
        romboInfDer[1] = new PointF(centerX + radio * 0.95f, centerY + radio * 0.9f);
        romboInfDer[2] = new PointF(centerX + radio * 0.7f, centerY + radio * 0.7f);
        romboInfDer[3] = new PointF(centerX + radio * 0.9f, centerY + radio * 0.95f);
        mGraph.DrawPolygon(mPen, romboInfDer);
    }

    private PointF[] CrearHexagono(float centerX, float centerY, float radio)
    {
        PointF[] puntos = new PointF[6];

        for (int i = 0; i < 6; i++)
        {
            double angulo = i * Math.PI / 3; // 60 grados en radianes
            puntos[i] = new PointF(
                centerX + (float)(radio * Math.Cos(angulo)),
                centerY + (float)(radio * Math.Sin(angulo))
            );
        }

        return puntos;
    }

    public void CloseForm(Form ObjForm)
    {
        ObjForm.Close();
    }
}