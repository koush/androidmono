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
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.microedition.khronos.opengles.GL11.glColorPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorPointer", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.microedition.khronos.opengles.GL11.glDrawElements(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawElements", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.microedition.khronos.opengles.GL11.glNormalPointer(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormalPointer", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void javax.microedition.khronos.opengles.GL11.glTexCoordPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexCoordPointer", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void javax.microedition.khronos.opengles.GL11.glVertexPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glVertexPointer", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void javax.microedition.khronos.opengles.GL11.glBindBuffer(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBindBuffer", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void javax.microedition.khronos.opengles.GL11.glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V", ref global::javax.microedition.khronos.opengles.GL11_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void javax.microedition.khronos.opengles.GL11.glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void javax.microedition.khronos.opengles.GL11.glClipPlanef(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanef", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void javax.microedition.khronos.opengles.GL11.glClipPlanef(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanef", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void javax.microedition.khronos.opengles.GL11.glClipPlanex(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanex", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void javax.microedition.khronos.opengles.GL11.glClipPlanex(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanex", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void javax.microedition.khronos.opengles.GL11.glColor4ub(byte arg0, byte arg1, byte arg2, byte arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4ub", "(BBBB)V", ref global::javax.microedition.khronos.opengles.GL11_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void javax.microedition.khronos.opengles.GL11.glDeleteBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteBuffers", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void javax.microedition.khronos.opengles.GL11.glDeleteBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void javax.microedition.khronos.opengles.GL11.glGenBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenBuffers", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void javax.microedition.khronos.opengles.GL11.glGenBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void javax.microedition.khronos.opengles.GL11.glGetBooleanv(int arg0, bool[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBooleanv", "(I[ZI)V", ref global::javax.microedition.khronos.opengles.GL11_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void javax.microedition.khronos.opengles.GL11.glGetBooleanv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void javax.microedition.khronos.opengles.GL11.glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBufferParameteriv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void javax.microedition.khronos.opengles.GL11.glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		void javax.microedition.khronos.opengles.GL11.glGetClipPlanef(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanef", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void javax.microedition.khronos.opengles.GL11.glGetClipPlanef(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		void javax.microedition.khronos.opengles.GL11.glGetClipPlanex(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanex", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void javax.microedition.khronos.opengles.GL11.glGetClipPlanex(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanex", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		void javax.microedition.khronos.opengles.GL11.glGetFixedv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFixedv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		void javax.microedition.khronos.opengles.GL11.glGetFixedv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFixedv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		void javax.microedition.khronos.opengles.GL11.glGetFloatv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFloatv", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		void javax.microedition.khronos.opengles.GL11.glGetFloatv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		void javax.microedition.khronos.opengles.GL11.glGetLightfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		void javax.microedition.khronos.opengles.GL11.glGetLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		void javax.microedition.khronos.opengles.GL11.glGetLightxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		void javax.microedition.khronos.opengles.GL11.glGetLightxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		void javax.microedition.khronos.opengles.GL11.glGetMaterialfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		void javax.microedition.khronos.opengles.GL11.glGetMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		void javax.microedition.khronos.opengles.GL11.glGetMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		void javax.microedition.khronos.opengles.GL11.glGetMaterialxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		void javax.microedition.khronos.opengles.GL11.glGetTexEnviv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnviv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		void javax.microedition.khronos.opengles.GL11.glGetTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnviv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		void javax.microedition.khronos.opengles.GL11.glGetTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnvxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		void javax.microedition.khronos.opengles.GL11.glGetTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameteriv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		void javax.microedition.khronos.opengles.GL11.glGetTexParameterxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		bool javax.microedition.khronos.opengles.GL11.glIsBuffer(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsBuffer", "(I)Z", ref global::javax.microedition.khronos.opengles.GL11_._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		bool javax.microedition.khronos.opengles.GL11.glIsEnabled(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsEnabled", "(I)Z", ref global::javax.microedition.khronos.opengles.GL11_._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		bool javax.microedition.khronos.opengles.GL11.glIsTexture(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsTexture", "(I)Z", ref global::javax.microedition.khronos.opengles.GL11_._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		void javax.microedition.khronos.opengles.GL11.glPointParameterf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterf", "(IF)V", ref global::javax.microedition.khronos.opengles.GL11_._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		void javax.microedition.khronos.opengles.GL11.glPointParameterfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterfv", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		void javax.microedition.khronos.opengles.GL11.glPointParameterfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterfv", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		void javax.microedition.khronos.opengles.GL11.glPointParameterx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterx", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		void javax.microedition.khronos.opengles.GL11.glPointParameterxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterxv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		void javax.microedition.khronos.opengles.GL11.glPointParameterxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterxv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		void javax.microedition.khronos.opengles.GL11.glPointSizePointerOES(int arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSizePointerOES", "(IILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		void javax.microedition.khronos.opengles.GL11.glTexEnvi(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvi", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		void javax.microedition.khronos.opengles.GL11.glTexEnviv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnviv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		void javax.microedition.khronos.opengles.GL11.glTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnviv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		void javax.microedition.khronos.opengles.GL11.glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		void javax.microedition.khronos.opengles.GL11.glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		void javax.microedition.khronos.opengles.GL11.glTexParameteri(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteri", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		void javax.microedition.khronos.opengles.GL11.glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteriv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		void javax.microedition.khronos.opengles.GL11.glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		void javax.microedition.khronos.opengles.GL11.glTexParameterxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		void javax.microedition.khronos.opengles.GL11.glTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		void javax.microedition.khronos.opengles.GL11.glGetPointerv(int arg0, java.nio.Buffer[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetPointerv", "(I[Ljava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		void javax.microedition.khronos.opengles.GL10.glActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glActiveTexture", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		void javax.microedition.khronos.opengles.GL10.glAlphaFunc(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glAlphaFunc", "(IF)V", ref global::javax.microedition.khronos.opengles.GL11_._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		void javax.microedition.khronos.opengles.GL10.glAlphaFuncx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glAlphaFuncx", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		void javax.microedition.khronos.opengles.GL10.glBindTexture(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBindTexture", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		void javax.microedition.khronos.opengles.GL10.glBlendFunc(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBlendFunc", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		void javax.microedition.khronos.opengles.GL10.glClear(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClear", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		void javax.microedition.khronos.opengles.GL10.glClearColor(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearColor", "(FFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		void javax.microedition.khronos.opengles.GL10.glClearColorx(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearColorx", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		void javax.microedition.khronos.opengles.GL10.glClearDepthf(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearDepthf", "(F)V", ref global::javax.microedition.khronos.opengles.GL11_._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		void javax.microedition.khronos.opengles.GL10.glClearDepthx(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearDepthx", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		void javax.microedition.khronos.opengles.GL10.glClearStencil(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearStencil", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		void javax.microedition.khronos.opengles.GL10.glClientActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClientActiveTexture", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		void javax.microedition.khronos.opengles.GL10.glColor4f(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4f", "(FFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		void javax.microedition.khronos.opengles.GL10.glColor4x(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4x", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		void javax.microedition.khronos.opengles.GL10.glColorMask(bool arg0, bool arg1, bool arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorMask", "(ZZZZ)V", ref global::javax.microedition.khronos.opengles.GL11_._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		void javax.microedition.khronos.opengles.GL10.glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m84;
		void javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		void javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m86;
		void javax.microedition.khronos.opengles.GL10.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m87;
		void javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m88;
		void javax.microedition.khronos.opengles.GL10.glCullFace(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCullFace", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m89;
		void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteTextures", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m90;
		void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		void javax.microedition.khronos.opengles.GL10.glDepthFunc(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthFunc", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m92;
		void javax.microedition.khronos.opengles.GL10.glDepthMask(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthMask", "(Z)V", ref global::javax.microedition.khronos.opengles.GL11_._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m93;
		void javax.microedition.khronos.opengles.GL10.glDepthRangef(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthRangef", "(FF)V", ref global::javax.microedition.khronos.opengles.GL11_._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m94;
		void javax.microedition.khronos.opengles.GL10.glDepthRangex(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthRangex", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m95;
		void javax.microedition.khronos.opengles.GL10.glDisable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDisable", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m96;
		void javax.microedition.khronos.opengles.GL10.glDisableClientState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDisableClientState", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m97;
		void javax.microedition.khronos.opengles.GL10.glDrawArrays(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawArrays", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m98;
		void javax.microedition.khronos.opengles.GL10.glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		void javax.microedition.khronos.opengles.GL10.glEnable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glEnable", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m100;
		void javax.microedition.khronos.opengles.GL10.glEnableClientState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glEnableClientState", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m101;
		void javax.microedition.khronos.opengles.GL10.glFinish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFinish", "()V", ref global::javax.microedition.khronos.opengles.GL11_._m101);
		}
		private static global::MonoJavaBridge.MethodId _m102;
		void javax.microedition.khronos.opengles.GL10.glFlush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFlush", "()V", ref global::javax.microedition.khronos.opengles.GL11_._m102);
		}
		private static global::MonoJavaBridge.MethodId _m103;
		void javax.microedition.khronos.opengles.GL10.glFogf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogf", "(IF)V", ref global::javax.microedition.khronos.opengles.GL11_._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m104;
		void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogfv", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m105;
		void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m106;
		void javax.microedition.khronos.opengles.GL10.glFogx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogx", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m107;
		void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogxv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m108;
		void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m109;
		void javax.microedition.khronos.opengles.GL10.glFrontFace(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrontFace", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m110;
		void javax.microedition.khronos.opengles.GL10.glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrustumf", "(FFFFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._m110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m111;
		void javax.microedition.khronos.opengles.GL10.glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrustumx", "(IIIIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m112;
		void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenTextures", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m113;
		void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m114;
		int javax.microedition.khronos.opengles.GL10.glGetError()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetError", "()I", ref global::javax.microedition.khronos.opengles.GL11_._m114);
		}
		private static global::MonoJavaBridge.MethodId _m115;
		void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetIntegerv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m116;
		void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m117;
		global::java.lang.String javax.microedition.khronos.opengles.GL10.glGetString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetString", "(I)Ljava/lang/String;", ref global::javax.microedition.khronos.opengles.GL11_._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m118;
		void javax.microedition.khronos.opengles.GL10.glHint(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glHint", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m119;
		void javax.microedition.khronos.opengles.GL10.glLightModelf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelf", "(IF)V", ref global::javax.microedition.khronos.opengles.GL11_._m119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m120;
		void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelfv", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m121;
		void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m122;
		void javax.microedition.khronos.opengles.GL10.glLightModelx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelx", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m123;
		void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelxv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m124;
		void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m125;
		void javax.microedition.khronos.opengles.GL10.glLightf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11_._m125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m126;
		void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m127;
		void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m128;
		void javax.microedition.khronos.opengles.GL10.glLightx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightx", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m129;
		void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m130;
		void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m131;
		void javax.microedition.khronos.opengles.GL10.glLineWidth(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLineWidth", "(F)V", ref global::javax.microedition.khronos.opengles.GL11_._m131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m132;
		void javax.microedition.khronos.opengles.GL10.glLineWidthx(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLineWidthx", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m133;
		void javax.microedition.khronos.opengles.GL10.glLoadIdentity()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadIdentity", "()V", ref global::javax.microedition.khronos.opengles.GL11_._m133);
		}
		private static global::MonoJavaBridge.MethodId _m134;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixf", "([FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m135;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m136;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixx", "([II)V", ref global::javax.microedition.khronos.opengles.GL11_._m136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m137;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m138;
		void javax.microedition.khronos.opengles.GL10.glLogicOp(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLogicOp", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m139;
		void javax.microedition.khronos.opengles.GL10.glMaterialf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11_._m139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m140;
		void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m141;
		void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m142;
		void javax.microedition.khronos.opengles.GL10.glMaterialx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialx", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m143;
		void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m144;
		void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m145;
		void javax.microedition.khronos.opengles.GL10.glMatrixMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMatrixMode", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m146;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixf", "([FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m147;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m148;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixx", "([II)V", ref global::javax.microedition.khronos.opengles.GL11_._m148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m149;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m150;
		void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultiTexCoord4f", "(IFFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._m150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m151;
		void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultiTexCoord4x", "(IIIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m152;
		void javax.microedition.khronos.opengles.GL10.glNormal3f(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormal3f", "(FFF)V", ref global::javax.microedition.khronos.opengles.GL11_._m152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m153;
		void javax.microedition.khronos.opengles.GL10.glNormal3x(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormal3x", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m154;
		void javax.microedition.khronos.opengles.GL10.glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m155;
		void javax.microedition.khronos.opengles.GL10.glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glOrthof", "(FFFFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._m155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m156;
		void javax.microedition.khronos.opengles.GL10.glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glOrthox", "(IIIIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m157;
		void javax.microedition.khronos.opengles.GL10.glPixelStorei(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPixelStorei", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m158;
		void javax.microedition.khronos.opengles.GL10.glPointSize(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSize", "(F)V", ref global::javax.microedition.khronos.opengles.GL11_._m158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m159;
		void javax.microedition.khronos.opengles.GL10.glPointSizex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSizex", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m160;
		void javax.microedition.khronos.opengles.GL10.glPolygonOffset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPolygonOffset", "(FF)V", ref global::javax.microedition.khronos.opengles.GL11_._m160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m161;
		void javax.microedition.khronos.opengles.GL10.glPolygonOffsetx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPolygonOffsetx", "(II)V", ref global::javax.microedition.khronos.opengles.GL11_._m161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m162;
		void javax.microedition.khronos.opengles.GL10.glPopMatrix()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPopMatrix", "()V", ref global::javax.microedition.khronos.opengles.GL11_._m162);
		}
		private static global::MonoJavaBridge.MethodId _m163;
		void javax.microedition.khronos.opengles.GL10.glPushMatrix()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPushMatrix", "()V", ref global::javax.microedition.khronos.opengles.GL11_._m163);
		}
		private static global::MonoJavaBridge.MethodId _m164;
		void javax.microedition.khronos.opengles.GL10.glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m165;
		void javax.microedition.khronos.opengles.GL10.glRotatef(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glRotatef", "(FFFF)V", ref global::javax.microedition.khronos.opengles.GL11_._m165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m166;
		void javax.microedition.khronos.opengles.GL10.glRotatex(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glRotatex", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m167;
		void javax.microedition.khronos.opengles.GL10.glSampleCoverage(float arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glSampleCoverage", "(FZ)V", ref global::javax.microedition.khronos.opengles.GL11_._m167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m168;
		void javax.microedition.khronos.opengles.GL10.glSampleCoveragex(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glSampleCoveragex", "(IZ)V", ref global::javax.microedition.khronos.opengles.GL11_._m168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m169;
		void javax.microedition.khronos.opengles.GL10.glScalef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScalef", "(FFF)V", ref global::javax.microedition.khronos.opengles.GL11_._m169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m170;
		void javax.microedition.khronos.opengles.GL10.glScalex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScalex", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m171;
		void javax.microedition.khronos.opengles.GL10.glScissor(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScissor", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m172;
		void javax.microedition.khronos.opengles.GL10.glShadeModel(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glShadeModel", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m173;
		void javax.microedition.khronos.opengles.GL10.glStencilFunc(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilFunc", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m174;
		void javax.microedition.khronos.opengles.GL10.glStencilMask(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilMask", "(I)V", ref global::javax.microedition.khronos.opengles.GL11_._m174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m175;
		void javax.microedition.khronos.opengles.GL10.glStencilOp(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilOp", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m176;
		void javax.microedition.khronos.opengles.GL10.glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m177;
		void javax.microedition.khronos.opengles.GL10.glTexEnvf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11_._m177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m178;
		void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11_._m178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m179;
		void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m180;
		void javax.microedition.khronos.opengles.GL10.glTexEnvx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvx", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m181;
		void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11_._m181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m182;
		void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m183;
		void javax.microedition.khronos.opengles.GL10.glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m184;
		void javax.microedition.khronos.opengles.GL10.glTexParameterf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11_._m184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m185;
		void javax.microedition.khronos.opengles.GL10.glTexParameterx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterx", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m186;
		void javax.microedition.khronos.opengles.GL10.glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m187;
		void javax.microedition.khronos.opengles.GL10.glTranslatef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTranslatef", "(FFF)V", ref global::javax.microedition.khronos.opengles.GL11_._m187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m188;
		void javax.microedition.khronos.opengles.GL10.glTranslatex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTranslatex", "(III)V", ref global::javax.microedition.khronos.opengles.GL11_._m188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m189;
		void javax.microedition.khronos.opengles.GL10.glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11_._m189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m190;
		void javax.microedition.khronos.opengles.GL10.glViewport(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11_.staticClass, "glViewport", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11_._m190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static GL11_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL11_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL11"));
		}
	}
}
