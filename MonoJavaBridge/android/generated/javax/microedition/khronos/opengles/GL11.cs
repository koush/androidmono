namespace javax.microedition.khronos.opengles
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.opengles.GL11_))]
	public partial interface GL11 : GL10
	{
		void glColorPointer(int arg0, int arg1, int arg2, int arg3);
		void glDrawElements(int arg0, int arg1, int arg2, int arg3);
		void glNormalPointer(int arg0, int arg1, int arg2);
		void glTexCoordPointer(int arg0, int arg1, int arg2, int arg3);
		void glVertexPointer(int arg0, int arg1, int arg2, int arg3);
		void glBindBuffer(int arg0, int arg1);
		void glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3);
		void glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3);
		void glClipPlanef(int arg0, java.nio.FloatBuffer arg1);
		void glClipPlanef(int arg0, float[] arg1, int arg2);
		void glClipPlanex(int arg0, int[] arg1, int arg2);
		void glClipPlanex(int arg0, java.nio.IntBuffer arg1);
		void glColor4ub(byte arg0, byte arg1, byte arg2, byte arg3);
		void glDeleteBuffers(int arg0, int[] arg1, int arg2);
		void glDeleteBuffers(int arg0, java.nio.IntBuffer arg1);
		void glGenBuffers(int arg0, int[] arg1, int arg2);
		void glGenBuffers(int arg0, java.nio.IntBuffer arg1);
		void glGetBooleanv(int arg0, bool[] arg1, int arg2);
		void glGetBooleanv(int arg0, java.nio.IntBuffer arg1);
		void glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3);
		void glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glGetClipPlanef(int arg0, float[] arg1, int arg2);
		void glGetClipPlanef(int arg0, java.nio.FloatBuffer arg1);
		void glGetClipPlanex(int arg0, int[] arg1, int arg2);
		void glGetClipPlanex(int arg0, java.nio.IntBuffer arg1);
		void glGetFixedv(int arg0, int[] arg1, int arg2);
		void glGetFixedv(int arg0, java.nio.IntBuffer arg1);
		void glGetFloatv(int arg0, float[] arg1, int arg2);
		void glGetFloatv(int arg0, java.nio.FloatBuffer arg1);
		void glGetLightfv(int arg0, int arg1, float[] arg2, int arg3);
		void glGetLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2);
		void glGetLightxv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glGetLightxv(int arg0, int arg1, int[] arg2, int arg3);
		void glGetMaterialfv(int arg0, int arg1, float[] arg2, int arg3);
		void glGetMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2);
		void glGetMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glGetMaterialxv(int arg0, int arg1, int[] arg2, int arg3);
		void glGetTexEnviv(int arg0, int arg1, int[] arg2, int arg3);
		void glGetTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glGetTexEnvxv(int arg0, int arg1, int[] arg2, int arg3);
		void glGetTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3);
		void glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2);
		void glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3);
		void glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glGetTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glGetTexParameterxv(int arg0, int arg1, int[] arg2, int arg3);
		bool glIsBuffer(int arg0);
		bool glIsEnabled(int arg0);
		bool glIsTexture(int arg0);
		void glPointParameterf(int arg0, float arg1);
		void glPointParameterfv(int arg0, float[] arg1, int arg2);
		void glPointParameterfv(int arg0, java.nio.FloatBuffer arg1);
		void glPointParameterx(int arg0, int arg1);
		void glPointParameterxv(int arg0, java.nio.IntBuffer arg1);
		void glPointParameterxv(int arg0, int[] arg1, int arg2);
		void glPointSizePointerOES(int arg0, int arg1, java.nio.Buffer arg2);
		void glTexEnvi(int arg0, int arg1, int arg2);
		void glTexEnviv(int arg0, int arg1, int[] arg2, int arg3);
		void glTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2);
		void glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3);
		void glTexParameteri(int arg0, int arg1, int arg2);
		void glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3);
		void glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glTexParameterxv(int arg0, int arg1, int[] arg2, int arg3);
		void glTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glGetPointerv(int arg0, java.nio.Buffer[] arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.opengles.GL11))]
	internal sealed partial class GL11_ : java.lang.Object, GL11
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GL11_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glColorPointer29320;
		void javax.microedition.khronos.opengles.GL11.glColorPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorPointer", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glColorPointer29320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements29321;
		void javax.microedition.khronos.opengles.GL11.glDrawElements(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawElements", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glDrawElements29321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer29322;
		void javax.microedition.khronos.opengles.GL11.glNormalPointer(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormalPointer", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glNormalPointer29322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer29323;
		void javax.microedition.khronos.opengles.GL11.glTexCoordPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexCoordPointer", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer29323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer29324;
		void javax.microedition.khronos.opengles.GL11.glVertexPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glVertexPointer", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glVertexPointer29324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBindBuffer29325;
		void javax.microedition.khronos.opengles.GL11.glBindBuffer(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBindBuffer", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glBindBuffer29325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferData29326;
		void javax.microedition.khronos.opengles.GL11.glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V", ref global::javax.microedition.khronos.opengles.GL11_._glBufferData29326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferSubData29327;
		void javax.microedition.khronos.opengles.GL11.glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glBufferSubData29327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanef29328;
		void javax.microedition.khronos.opengles.GL11.glClipPlanef(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanef", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glClipPlanef29328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanef29329;
		void javax.microedition.khronos.opengles.GL11.glClipPlanef(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanef", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glClipPlanef29329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanex29330;
		void javax.microedition.khronos.opengles.GL11.glClipPlanex(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanex", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glClipPlanex29330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanex29331;
		void javax.microedition.khronos.opengles.GL11.glClipPlanex(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanex", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glClipPlanex29331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4ub29332;
		void javax.microedition.khronos.opengles.GL11.glColor4ub(byte arg0, byte arg1, byte arg2, byte arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4ub", "(BBBB)V", ref global::javax.microedition.khronos.opengles.GL11_._glColor4ub29332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers29333;
		void javax.microedition.khronos.opengles.GL11.glDeleteBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteBuffers", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers29333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers29334;
		void javax.microedition.khronos.opengles.GL11.glDeleteBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers29334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers29335;
		void javax.microedition.khronos.opengles.GL11.glGenBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenBuffers", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGenBuffers29335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers29336;
		void javax.microedition.khronos.opengles.GL11.glGenBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGenBuffers29336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv29337;
		void javax.microedition.khronos.opengles.GL11.glGetBooleanv(int arg0, bool[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBooleanv", "(I[ZI)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv29337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv29338;
		void javax.microedition.khronos.opengles.GL11.glGetBooleanv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv29338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv29339;
		void javax.microedition.khronos.opengles.GL11.glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBufferParameteriv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv29339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv29340;
		void javax.microedition.khronos.opengles.GL11.glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv29340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanef29341;
		void javax.microedition.khronos.opengles.GL11.glGetClipPlanef(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanef", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef29341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanef29342;
		void javax.microedition.khronos.opengles.GL11.glGetClipPlanef(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef29342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanex29343;
		void javax.microedition.khronos.opengles.GL11.glGetClipPlanex(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanex", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex29343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanex29344;
		void javax.microedition.khronos.opengles.GL11.glGetClipPlanex(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanex", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex29344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedv29345;
		void javax.microedition.khronos.opengles.GL11.glGetFixedv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFixedv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetFixedv29345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedv29346;
		void javax.microedition.khronos.opengles.GL11.glGetFixedv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFixedv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetFixedv29346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv29347;
		void javax.microedition.khronos.opengles.GL11.glGetFloatv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFloatv", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetFloatv29347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv29348;
		void javax.microedition.khronos.opengles.GL11.glGetFloatv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetFloatv29348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightfv29349;
		void javax.microedition.khronos.opengles.GL11.glGetLightfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetLightfv29349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightfv29350;
		void javax.microedition.khronos.opengles.GL11.glGetLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetLightfv29350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxv29351;
		void javax.microedition.khronos.opengles.GL11.glGetLightxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetLightxv29351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxv29352;
		void javax.microedition.khronos.opengles.GL11.glGetLightxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetLightxv29352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialfv29353;
		void javax.microedition.khronos.opengles.GL11.glGetMaterialfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv29353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialfv29354;
		void javax.microedition.khronos.opengles.GL11.glGetMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv29354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxv29355;
		void javax.microedition.khronos.opengles.GL11.glGetMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv29355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxv29356;
		void javax.microedition.khronos.opengles.GL11.glGetMaterialxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv29356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnviv29357;
		void javax.microedition.khronos.opengles.GL11.glGetTexEnviv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnviv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv29357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnviv29358;
		void javax.microedition.khronos.opengles.GL11.glGetTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnviv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv29358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxv29359;
		void javax.microedition.khronos.opengles.GL11.glGetTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnvxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv29359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxv29360;
		void javax.microedition.khronos.opengles.GL11.glGetTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv29360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv29361;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv29361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv29362;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv29362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv29363;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameteriv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv29363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv29364;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv29364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxv29365;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv29365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxv29366;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameterxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv29366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glIsBuffer29367;
		bool javax.microedition.khronos.opengles.GL11.glIsBuffer(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsBuffer", "(I)Z", ref global::javax.microedition.khronos.opengles.GL11_._glIsBuffer29367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsEnabled29368;
		bool javax.microedition.khronos.opengles.GL11.glIsEnabled(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsEnabled", "(I)Z", ref global::javax.microedition.khronos.opengles.GL11_._glIsEnabled29368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsTexture29369;
		bool javax.microedition.khronos.opengles.GL11.glIsTexture(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsTexture", "(I)Z", ref global::javax.microedition.khronos.opengles.GL11_._glIsTexture29369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterf29370;
		void javax.microedition.khronos.opengles.GL11.glPointParameterf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterf", "(IF)V", ref global::javax.microedition.khronos.opengles.GL11_._glPointParameterf29370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterfv29371;
		void javax.microedition.khronos.opengles.GL11.glPointParameterfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterfv", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv29371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterfv29372;
		void javax.microedition.khronos.opengles.GL11.glPointParameterfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterfv", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv29372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterx29373;
		void javax.microedition.khronos.opengles.GL11.glPointParameterx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterx", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glPointParameterx29373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxv29374;
		void javax.microedition.khronos.opengles.GL11.glPointParameterxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterxv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv29374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxv29375;
		void javax.microedition.khronos.opengles.GL11.glPointParameterxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterxv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv29375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizePointerOES29376;
		void javax.microedition.khronos.opengles.GL11.glPointSizePointerOES(int arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSizePointerOES", "(IILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glPointSizePointerOES29376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvi29377;
		void javax.microedition.khronos.opengles.GL11.glTexEnvi(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvi", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexEnvi29377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnviv29378;
		void javax.microedition.khronos.opengles.GL11.glTexEnviv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnviv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexEnviv29378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnviv29379;
		void javax.microedition.khronos.opengles.GL11.glTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnviv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexEnviv29379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv29380;
		void javax.microedition.khronos.opengles.GL11.glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv29380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv29381;
		void javax.microedition.khronos.opengles.GL11.glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv29381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteri29382;
		void javax.microedition.khronos.opengles.GL11.glTexParameteri(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteri", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexParameteri29382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv29383;
		void javax.microedition.khronos.opengles.GL11.glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteriv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv29383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv29384;
		void javax.microedition.khronos.opengles.GL11.glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv29384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxv29385;
		void javax.microedition.khronos.opengles.GL11.glTexParameterxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv29385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxv29386;
		void javax.microedition.khronos.opengles.GL11.glTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv29386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetPointerv29387;
		void javax.microedition.khronos.opengles.GL11.glGetPointerv(int arg0, java.nio.Buffer[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetPointerv", "(I[Ljava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetPointerv29387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glActiveTexture29388;
		void javax.microedition.khronos.opengles.GL10.glActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glActiveTexture", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glActiveTexture29388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFunc29389;
		void javax.microedition.khronos.opengles.GL10.glAlphaFunc(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glAlphaFunc", "(IF)V", ref global::javax.microedition.khronos.opengles.GL11_._glAlphaFunc29389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFuncx29390;
		void javax.microedition.khronos.opengles.GL10.glAlphaFuncx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glAlphaFuncx", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glAlphaFuncx29390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBindTexture29391;
		void javax.microedition.khronos.opengles.GL10.glBindTexture(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBindTexture", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glBindTexture29391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFunc29392;
		void javax.microedition.khronos.opengles.GL10.glBlendFunc(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBlendFunc", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glBlendFunc29392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClear29393;
		void javax.microedition.khronos.opengles.GL10.glClear(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClear", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glClear29393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColor29394;
		void javax.microedition.khronos.opengles.GL10.glClearColor(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearColor", "(FFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._glClearColor29394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColorx29395;
		void javax.microedition.khronos.opengles.GL10.glClearColorx(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearColorx", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glClearColorx29395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthf29396;
		void javax.microedition.khronos.opengles.GL10.glClearDepthf(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearDepthf", "(F)V", ref global::javax.microedition.khronos.opengles.GL11_._glClearDepthf29396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthx29397;
		void javax.microedition.khronos.opengles.GL10.glClearDepthx(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearDepthx", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glClearDepthx29397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearStencil29398;
		void javax.microedition.khronos.opengles.GL10.glClearStencil(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearStencil", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glClearStencil29398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClientActiveTexture29399;
		void javax.microedition.khronos.opengles.GL10.glClientActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClientActiveTexture", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glClientActiveTexture29399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4f29400;
		void javax.microedition.khronos.opengles.GL10.glColor4f(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4f", "(FFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._glColor4f29400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4x29401;
		void javax.microedition.khronos.opengles.GL10.glColor4x(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4x", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glColor4x29401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorMask29402;
		void javax.microedition.khronos.opengles.GL10.glColorMask(bool arg0, bool arg1, bool arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorMask", "(ZZZZ)V", ref global::javax.microedition.khronos.opengles.GL11_._glColorMask29402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorPointer29403;
		void javax.microedition.khronos.opengles.GL10.glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glColorPointer29403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D29404;
		void javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glCompressedTexImage2D29404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexSubImage2D29405;
		void javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glCompressedTexSubImage2D29405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D29406;
		void javax.microedition.khronos.opengles.GL10.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glCopyTexImage2D29406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexSubImage2D29407;
		void javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glCopyTexSubImage2D29407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCullFace29408;
		void javax.microedition.khronos.opengles.GL10.glCullFace(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCullFace", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glCullFace29408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures29409;
		void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteTextures", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures29409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures29410;
		void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures29410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthFunc29411;
		void javax.microedition.khronos.opengles.GL10.glDepthFunc(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthFunc", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glDepthFunc29411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthMask29412;
		void javax.microedition.khronos.opengles.GL10.glDepthMask(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthMask", "(Z)V", ref global::javax.microedition.khronos.opengles.GL11_._glDepthMask29412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangef29413;
		void javax.microedition.khronos.opengles.GL10.glDepthRangef(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthRangef", "(FF)V", ref global::javax.microedition.khronos.opengles.GL11_._glDepthRangef29413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangex29414;
		void javax.microedition.khronos.opengles.GL10.glDepthRangex(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthRangex", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glDepthRangex29414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDisable29415;
		void javax.microedition.khronos.opengles.GL10.glDisable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDisable", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glDisable29415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDisableClientState29416;
		void javax.microedition.khronos.opengles.GL10.glDisableClientState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDisableClientState", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glDisableClientState29416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawArrays29417;
		void javax.microedition.khronos.opengles.GL10.glDrawArrays(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawArrays", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glDrawArrays29417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements29418;
		void javax.microedition.khronos.opengles.GL10.glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glDrawElements29418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable29419;
		void javax.microedition.khronos.opengles.GL10.glEnable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glEnable", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glEnable29419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEnableClientState29420;
		void javax.microedition.khronos.opengles.GL10.glEnableClientState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glEnableClientState", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glEnableClientState29420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFinish29421;
		void javax.microedition.khronos.opengles.GL10.glFinish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFinish", "()V", ref global::javax.microedition.khronos.opengles.GL11_._glFinish29421);
		}
		internal static global::MonoJavaBridge.MethodId _glFlush29422;
		void javax.microedition.khronos.opengles.GL10.glFlush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFlush", "()V", ref global::javax.microedition.khronos.opengles.GL11_._glFlush29422);
		}
		internal static global::MonoJavaBridge.MethodId _glFogf29423;
		void javax.microedition.khronos.opengles.GL10.glFogf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogf", "(IF)V", ref global::javax.microedition.khronos.opengles.GL11_._glFogf29423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv29424;
		void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogfv", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glFogfv29424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv29425;
		void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glFogfv29425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogx29426;
		void javax.microedition.khronos.opengles.GL10.glFogx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogx", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glFogx29426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv29427;
		void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogxv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glFogxv29427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv29428;
		void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glFogxv29428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrontFace29429;
		void javax.microedition.khronos.opengles.GL10.glFrontFace(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrontFace", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glFrontFace29429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumf29430;
		void javax.microedition.khronos.opengles.GL10.glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrustumf", "(FFFFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._glFrustumf29430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumx29431;
		void javax.microedition.khronos.opengles.GL10.glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrustumx", "(IIIIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glFrustumx29431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures29432;
		void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenTextures", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGenTextures29432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures29433;
		void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGenTextures29433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetError29434;
		int javax.microedition.khronos.opengles.GL10.glGetError()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetError", "()I", ref global::javax.microedition.khronos.opengles.GL11_._glGetError29434);
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv29435;
		void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetIntegerv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv29435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv29436;
		void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv29436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetString29437;
		global::java.lang.String javax.microedition.khronos.opengles.GL10.glGetString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetString", "(I)Ljava/lang/String;", ref global::javax.microedition.khronos.opengles.GL11_._glGetString29437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _glHint29438;
		void javax.microedition.khronos.opengles.GL10.glHint(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glHint", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glHint29438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelf29439;
		void javax.microedition.khronos.opengles.GL10.glLightModelf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelf", "(IF)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightModelf29439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv29440;
		void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelfv", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightModelfv29440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv29441;
		void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightModelfv29441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelx29442;
		void javax.microedition.khronos.opengles.GL10.glLightModelx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelx", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightModelx29442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv29443;
		void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelxv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightModelxv29443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv29444;
		void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightModelxv29444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightf29445;
		void javax.microedition.khronos.opengles.GL10.glLightf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightf29445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv29446;
		void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightfv29446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv29447;
		void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightfv29447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightx29448;
		void javax.microedition.khronos.opengles.GL10.glLightx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightx", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightx29448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv29449;
		void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightxv29449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv29450;
		void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glLightxv29450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidth29451;
		void javax.microedition.khronos.opengles.GL10.glLineWidth(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLineWidth", "(F)V", ref global::javax.microedition.khronos.opengles.GL11_._glLineWidth29451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidthx29452;
		void javax.microedition.khronos.opengles.GL10.glLineWidthx(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLineWidthx", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glLineWidthx29452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadIdentity29453;
		void javax.microedition.khronos.opengles.GL10.glLoadIdentity()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadIdentity", "()V", ref global::javax.microedition.khronos.opengles.GL11_._glLoadIdentity29453);
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf29454;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixf", "([FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf29454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf29455;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf29455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx29456;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixx", "([II)V", ref global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx29456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx29457;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx29457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLogicOp29458;
		void javax.microedition.khronos.opengles.GL10.glLogicOp(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLogicOp", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glLogicOp29458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialf29459;
		void javax.microedition.khronos.opengles.GL10.glMaterialf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11_._glMaterialf29459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv29460;
		void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glMaterialfv29460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv29461;
		void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glMaterialfv29461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialx29462;
		void javax.microedition.khronos.opengles.GL10.glMaterialx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialx", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glMaterialx29462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv29463;
		void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glMaterialxv29463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv29464;
		void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glMaterialxv29464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixMode29465;
		void javax.microedition.khronos.opengles.GL10.glMatrixMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMatrixMode", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glMatrixMode29465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf29466;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixf", "([FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf29466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf29467;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf29467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx29468;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixx", "([II)V", ref global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx29468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx29469;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx29469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4f29470;
		void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultiTexCoord4f", "(IFFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4f29470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4x29471;
		void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultiTexCoord4x", "(IIIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4x29471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3f29472;
		void javax.microedition.khronos.opengles.GL10.glNormal3f(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormal3f", "(FFF)V", ref global::javax.microedition.khronos.opengles.GL11_._glNormal3f29472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3x29473;
		void javax.microedition.khronos.opengles.GL10.glNormal3x(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormal3x", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glNormal3x29473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer29474;
		void javax.microedition.khronos.opengles.GL10.glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glNormalPointer29474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthof29475;
		void javax.microedition.khronos.opengles.GL10.glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glOrthof", "(FFFFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._glOrthof29475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthox29476;
		void javax.microedition.khronos.opengles.GL10.glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glOrthox", "(IIIIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glOrthox29476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glPixelStorei29477;
		void javax.microedition.khronos.opengles.GL10.glPixelStorei(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPixelStorei", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glPixelStorei29477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSize29478;
		void javax.microedition.khronos.opengles.GL10.glPointSize(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSize", "(F)V", ref global::javax.microedition.khronos.opengles.GL11_._glPointSize29478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizex29479;
		void javax.microedition.khronos.opengles.GL10.glPointSizex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSizex", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glPointSizex29479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffset29480;
		void javax.microedition.khronos.opengles.GL10.glPolygonOffset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPolygonOffset", "(FF)V", ref global::javax.microedition.khronos.opengles.GL11_._glPolygonOffset29480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffsetx29481;
		void javax.microedition.khronos.opengles.GL10.glPolygonOffsetx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPolygonOffsetx", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._glPolygonOffsetx29481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPopMatrix29482;
		void javax.microedition.khronos.opengles.GL10.glPopMatrix()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPopMatrix", "()V", ref global::javax.microedition.khronos.opengles.GL11_._glPopMatrix29482);
		}
		internal static global::MonoJavaBridge.MethodId _glPushMatrix29483;
		void javax.microedition.khronos.opengles.GL10.glPushMatrix()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPushMatrix", "()V", ref global::javax.microedition.khronos.opengles.GL11_._glPushMatrix29483);
		}
		internal static global::MonoJavaBridge.MethodId _glReadPixels29484;
		void javax.microedition.khronos.opengles.GL10.glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glReadPixels29484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatef29485;
		void javax.microedition.khronos.opengles.GL10.glRotatef(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glRotatef", "(FFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._glRotatef29485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatex29486;
		void javax.microedition.khronos.opengles.GL10.glRotatex(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glRotatex", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glRotatex29486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoverage29487;
		void javax.microedition.khronos.opengles.GL10.glSampleCoverage(float arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glSampleCoverage", "(FZ)V", ref global::javax.microedition.khronos.opengles.GL11_._glSampleCoverage29487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoveragex29488;
		void javax.microedition.khronos.opengles.GL10.glSampleCoveragex(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glSampleCoveragex", "(IZ)V", ref global::javax.microedition.khronos.opengles.GL11_._glSampleCoveragex29488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glScalef29489;
		void javax.microedition.khronos.opengles.GL10.glScalef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScalef", "(FFF)V", ref global::javax.microedition.khronos.opengles.GL11_._glScalef29489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScalex29490;
		void javax.microedition.khronos.opengles.GL10.glScalex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScalex", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glScalex29490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScissor29491;
		void javax.microedition.khronos.opengles.GL10.glScissor(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScissor", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glScissor29491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glShadeModel29492;
		void javax.microedition.khronos.opengles.GL10.glShadeModel(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glShadeModel", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glShadeModel29492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilFunc29493;
		void javax.microedition.khronos.opengles.GL10.glStencilFunc(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilFunc", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glStencilFunc29493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilMask29494;
		void javax.microedition.khronos.opengles.GL10.glStencilMask(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilMask", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._glStencilMask29494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp29495;
		void javax.microedition.khronos.opengles.GL10.glStencilOp(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilOp", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glStencilOp29495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer29496;
		void javax.microedition.khronos.opengles.GL10.glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer29496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvf29497;
		void javax.microedition.khronos.opengles.GL10.glTexEnvf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexEnvf29497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv29498;
		void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv29498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv29499;
		void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv29499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvx29500;
		void javax.microedition.khronos.opengles.GL10.glTexEnvx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvx", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexEnvx29500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv29501;
		void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv29501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv29502;
		void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv29502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexImage2D29503;
		void javax.microedition.khronos.opengles.GL10.glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexImage2D29503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf29504;
		void javax.microedition.khronos.opengles.GL10.glTexParameterf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexParameterf29504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterx29505;
		void javax.microedition.khronos.opengles.GL10.glTexParameterx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterx", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexParameterx29505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexSubImage2D29506;
		void javax.microedition.khronos.opengles.GL10.glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glTexSubImage2D29506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatef29507;
		void javax.microedition.khronos.opengles.GL10.glTranslatef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTranslatef", "(FFF)V", ref global::javax.microedition.khronos.opengles.GL11_._glTranslatef29507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatex29508;
		void javax.microedition.khronos.opengles.GL10.glTranslatex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTranslatex", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._glTranslatex29508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer29509;
		void javax.microedition.khronos.opengles.GL10.glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._glVertexPointer29509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glViewport29510;
		void javax.microedition.khronos.opengles.GL10.glViewport(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glViewport", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._glViewport29510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static GL11_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL11_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL11"));
		}
		internal static void InitJNI()
		{
		}
	}
}
