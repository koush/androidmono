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
	public sealed partial class GL11_ : java.lang.Object, GL11
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GL11_()
		{
			InitJNI();
		}
		internal GL11_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glColorPointer29201;
		 void javax.microedition.khronos.opengles.GL11.glColorPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColorPointer29201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColorPointer29201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements29202;
		 void javax.microedition.khronos.opengles.GL11.glDrawElements(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDrawElements29202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDrawElements29202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer29203;
		 void javax.microedition.khronos.opengles.GL11.glNormalPointer(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glNormalPointer29203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glNormalPointer29203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer29204;
		 void javax.microedition.khronos.opengles.GL11.glTexCoordPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer29204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer29204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer29205;
		 void javax.microedition.khronos.opengles.GL11.glVertexPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glVertexPointer29205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glVertexPointer29205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBindBuffer29206;
		 void javax.microedition.khronos.opengles.GL11.glBindBuffer(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glBindBuffer29206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glBindBuffer29206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferData29207;
		 void javax.microedition.khronos.opengles.GL11.glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glBufferData29207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glBufferData29207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferSubData29208;
		 void javax.microedition.khronos.opengles.GL11.glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glBufferSubData29208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glBufferSubData29208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanef29209;
		 void javax.microedition.khronos.opengles.GL11.glClipPlanef(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClipPlanef29209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClipPlanef29209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanef29210;
		 void javax.microedition.khronos.opengles.GL11.glClipPlanef(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClipPlanef29210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClipPlanef29210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanex29211;
		 void javax.microedition.khronos.opengles.GL11.glClipPlanex(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClipPlanex29211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClipPlanex29211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanex29212;
		 void javax.microedition.khronos.opengles.GL11.glClipPlanex(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClipPlanex29212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClipPlanex29212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4ub29213;
		 void javax.microedition.khronos.opengles.GL11.glColor4ub(byte arg0, byte arg1, byte arg2, byte arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColor4ub29213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColor4ub29213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers29214;
		 void javax.microedition.khronos.opengles.GL11.glDeleteBuffers(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers29214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers29214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers29215;
		 void javax.microedition.khronos.opengles.GL11.glDeleteBuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers29215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers29215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers29216;
		 void javax.microedition.khronos.opengles.GL11.glGenBuffers(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGenBuffers29216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGenBuffers29216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers29217;
		 void javax.microedition.khronos.opengles.GL11.glGenBuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGenBuffers29217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGenBuffers29217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv29218;
		 void javax.microedition.khronos.opengles.GL11.glGetBooleanv(int arg0, bool[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv29218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv29218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv29219;
		 void javax.microedition.khronos.opengles.GL11.glGetBooleanv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv29219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv29219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv29220;
		 void javax.microedition.khronos.opengles.GL11.glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv29220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv29220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv29221;
		 void javax.microedition.khronos.opengles.GL11.glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv29221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv29221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanef29222;
		 void javax.microedition.khronos.opengles.GL11.glGetClipPlanef(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef29222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef29222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanef29223;
		 void javax.microedition.khronos.opengles.GL11.glGetClipPlanef(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef29223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef29223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanex29224;
		 void javax.microedition.khronos.opengles.GL11.glGetClipPlanex(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex29224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex29224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanex29225;
		 void javax.microedition.khronos.opengles.GL11.glGetClipPlanex(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex29225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex29225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedv29226;
		 void javax.microedition.khronos.opengles.GL11.glGetFixedv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetFixedv29226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetFixedv29226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedv29227;
		 void javax.microedition.khronos.opengles.GL11.glGetFixedv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetFixedv29227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetFixedv29227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv29228;
		 void javax.microedition.khronos.opengles.GL11.glGetFloatv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetFloatv29228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetFloatv29228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv29229;
		 void javax.microedition.khronos.opengles.GL11.glGetFloatv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetFloatv29229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetFloatv29229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightfv29230;
		 void javax.microedition.khronos.opengles.GL11.glGetLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetLightfv29230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetLightfv29230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightfv29231;
		 void javax.microedition.khronos.opengles.GL11.glGetLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetLightfv29231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetLightfv29231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxv29232;
		 void javax.microedition.khronos.opengles.GL11.glGetLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetLightxv29232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetLightxv29232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxv29233;
		 void javax.microedition.khronos.opengles.GL11.glGetLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetLightxv29233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetLightxv29233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialfv29234;
		 void javax.microedition.khronos.opengles.GL11.glGetMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv29234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv29234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialfv29235;
		 void javax.microedition.khronos.opengles.GL11.glGetMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv29235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv29235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxv29236;
		 void javax.microedition.khronos.opengles.GL11.glGetMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv29236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv29236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxv29237;
		 void javax.microedition.khronos.opengles.GL11.glGetMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv29237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv29237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnviv29238;
		 void javax.microedition.khronos.opengles.GL11.glGetTexEnviv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv29238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv29238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnviv29239;
		 void javax.microedition.khronos.opengles.GL11.glGetTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv29239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv29239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxv29240;
		 void javax.microedition.khronos.opengles.GL11.glGetTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv29240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv29240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxv29241;
		 void javax.microedition.khronos.opengles.GL11.glGetTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv29241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv29241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv29242;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv29242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv29242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv29243;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv29243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv29243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv29244;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv29244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv29244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv29245;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv29245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv29245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxv29246;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv29246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv29246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxv29247;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameterxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv29247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv29247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glIsBuffer29248;
		 bool javax.microedition.khronos.opengles.GL11.glIsBuffer(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glIsBuffer29248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glIsBuffer29248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsEnabled29249;
		 bool javax.microedition.khronos.opengles.GL11.glIsEnabled(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glIsEnabled29249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glIsEnabled29249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsTexture29250;
		 bool javax.microedition.khronos.opengles.GL11.glIsTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glIsTexture29250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glIsTexture29250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterf29251;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterf29251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterf29251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterfv29252;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv29252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv29252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterfv29253;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv29253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv29253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterx29254;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterx29254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterx29254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxv29255;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv29255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv29255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxv29256;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv29256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv29256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizePointerOES29257;
		 void javax.microedition.khronos.opengles.GL11.glPointSizePointerOES(int arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointSizePointerOES29257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointSizePointerOES29257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvi29258;
		 void javax.microedition.khronos.opengles.GL11.glTexEnvi(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvi29258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvi29258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnviv29259;
		 void javax.microedition.khronos.opengles.GL11.glTexEnviv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnviv29259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnviv29259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnviv29260;
		 void javax.microedition.khronos.opengles.GL11.glTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnviv29260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnviv29260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv29261;
		 void javax.microedition.khronos.opengles.GL11.glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv29261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv29261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv29262;
		 void javax.microedition.khronos.opengles.GL11.glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv29262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv29262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteri29263;
		 void javax.microedition.khronos.opengles.GL11.glTexParameteri(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameteri29263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameteri29263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv29264;
		 void javax.microedition.khronos.opengles.GL11.glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv29264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv29264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv29265;
		 void javax.microedition.khronos.opengles.GL11.glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv29265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv29265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxv29266;
		 void javax.microedition.khronos.opengles.GL11.glTexParameterxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv29266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv29266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxv29267;
		 void javax.microedition.khronos.opengles.GL11.glTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv29267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv29267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetPointerv29268;
		 void javax.microedition.khronos.opengles.GL11.glGetPointerv(int arg0, java.nio.Buffer[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetPointerv29268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetPointerv29268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glActiveTexture29269;
		 void javax.microedition.khronos.opengles.GL10.glActiveTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glActiveTexture29269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glActiveTexture29269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFunc29270;
		 void javax.microedition.khronos.opengles.GL10.glAlphaFunc(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glAlphaFunc29270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glAlphaFunc29270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFuncx29271;
		 void javax.microedition.khronos.opengles.GL10.glAlphaFuncx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glAlphaFuncx29271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glAlphaFuncx29271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBindTexture29272;
		 void javax.microedition.khronos.opengles.GL10.glBindTexture(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glBindTexture29272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glBindTexture29272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFunc29273;
		 void javax.microedition.khronos.opengles.GL10.glBlendFunc(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glBlendFunc29273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glBlendFunc29273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClear29274;
		 void javax.microedition.khronos.opengles.GL10.glClear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClear29274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClear29274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColor29275;
		 void javax.microedition.khronos.opengles.GL10.glClearColor(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClearColor29275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClearColor29275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColorx29276;
		 void javax.microedition.khronos.opengles.GL10.glClearColorx(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClearColorx29276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClearColorx29276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthf29277;
		 void javax.microedition.khronos.opengles.GL10.glClearDepthf(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClearDepthf29277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClearDepthf29277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthx29278;
		 void javax.microedition.khronos.opengles.GL10.glClearDepthx(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClearDepthx29278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClearDepthx29278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearStencil29279;
		 void javax.microedition.khronos.opengles.GL10.glClearStencil(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClearStencil29279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClearStencil29279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClientActiveTexture29280;
		 void javax.microedition.khronos.opengles.GL10.glClientActiveTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClientActiveTexture29280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClientActiveTexture29280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4f29281;
		 void javax.microedition.khronos.opengles.GL10.glColor4f(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColor4f29281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColor4f29281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4x29282;
		 void javax.microedition.khronos.opengles.GL10.glColor4x(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColor4x29282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColor4x29282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorMask29283;
		 void javax.microedition.khronos.opengles.GL10.glColorMask(bool arg0, bool arg1, bool arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColorMask29283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColorMask29283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorPointer29284;
		 void javax.microedition.khronos.opengles.GL10.glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColorPointer29284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColorPointer29284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D29285;
		 void javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glCompressedTexImage2D29285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glCompressedTexImage2D29285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexSubImage2D29286;
		 void javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glCompressedTexSubImage2D29286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glCompressedTexSubImage2D29286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D29287;
		 void javax.microedition.khronos.opengles.GL10.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glCopyTexImage2D29287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glCopyTexImage2D29287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexSubImage2D29288;
		 void javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glCopyTexSubImage2D29288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glCopyTexSubImage2D29288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCullFace29289;
		 void javax.microedition.khronos.opengles.GL10.glCullFace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glCullFace29289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glCullFace29289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures29290;
		 void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures29290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures29290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures29291;
		 void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures29291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures29291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthFunc29292;
		 void javax.microedition.khronos.opengles.GL10.glDepthFunc(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDepthFunc29292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDepthFunc29292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthMask29293;
		 void javax.microedition.khronos.opengles.GL10.glDepthMask(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDepthMask29293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDepthMask29293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangef29294;
		 void javax.microedition.khronos.opengles.GL10.glDepthRangef(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDepthRangef29294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDepthRangef29294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangex29295;
		 void javax.microedition.khronos.opengles.GL10.glDepthRangex(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDepthRangex29295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDepthRangex29295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDisable29296;
		 void javax.microedition.khronos.opengles.GL10.glDisable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDisable29296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDisable29296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDisableClientState29297;
		 void javax.microedition.khronos.opengles.GL10.glDisableClientState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDisableClientState29297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDisableClientState29297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawArrays29298;
		 void javax.microedition.khronos.opengles.GL10.glDrawArrays(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDrawArrays29298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDrawArrays29298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements29299;
		 void javax.microedition.khronos.opengles.GL10.glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDrawElements29299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDrawElements29299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable29300;
		 void javax.microedition.khronos.opengles.GL10.glEnable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glEnable29300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glEnable29300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEnableClientState29301;
		 void javax.microedition.khronos.opengles.GL10.glEnableClientState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glEnableClientState29301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glEnableClientState29301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFinish29302;
		 void javax.microedition.khronos.opengles.GL10.glFinish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFinish29302);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFinish29302);
		}
		internal static global::MonoJavaBridge.MethodId _glFlush29303;
		 void javax.microedition.khronos.opengles.GL10.glFlush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFlush29303);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFlush29303);
		}
		internal static global::MonoJavaBridge.MethodId _glFogf29304;
		 void javax.microedition.khronos.opengles.GL10.glFogf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogf29304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogf29304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv29305;
		 void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogfv29305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogfv29305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv29306;
		 void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogfv29306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogfv29306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogx29307;
		 void javax.microedition.khronos.opengles.GL10.glFogx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogx29307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogx29307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv29308;
		 void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogxv29308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogxv29308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv29309;
		 void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogxv29309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogxv29309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrontFace29310;
		 void javax.microedition.khronos.opengles.GL10.glFrontFace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFrontFace29310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFrontFace29310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumf29311;
		 void javax.microedition.khronos.opengles.GL10.glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFrustumf29311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFrustumf29311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumx29312;
		 void javax.microedition.khronos.opengles.GL10.glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFrustumx29312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFrustumx29312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures29313;
		 void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGenTextures29313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGenTextures29313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures29314;
		 void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGenTextures29314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGenTextures29314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetError29315;
		 int javax.microedition.khronos.opengles.GL10.glGetError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetError29315);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetError29315);
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv29316;
		 void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv29316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv29316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv29317;
		 void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv29317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv29317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetString29318;
		 global::java.lang.String javax.microedition.khronos.opengles.GL10.glGetString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetString29318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetString29318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _glHint29319;
		 void javax.microedition.khronos.opengles.GL10.glHint(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glHint29319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glHint29319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelf29320;
		 void javax.microedition.khronos.opengles.GL10.glLightModelf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelf29320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelf29320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv29321;
		 void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelfv29321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelfv29321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv29322;
		 void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelfv29322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelfv29322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelx29323;
		 void javax.microedition.khronos.opengles.GL10.glLightModelx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelx29323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelx29323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv29324;
		 void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelxv29324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelxv29324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv29325;
		 void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelxv29325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelxv29325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightf29326;
		 void javax.microedition.khronos.opengles.GL10.glLightf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightf29326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightf29326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv29327;
		 void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightfv29327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightfv29327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv29328;
		 void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightfv29328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightfv29328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightx29329;
		 void javax.microedition.khronos.opengles.GL10.glLightx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightx29329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightx29329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv29330;
		 void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightxv29330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightxv29330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv29331;
		 void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightxv29331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightxv29331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidth29332;
		 void javax.microedition.khronos.opengles.GL10.glLineWidth(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLineWidth29332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLineWidth29332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidthx29333;
		 void javax.microedition.khronos.opengles.GL10.glLineWidthx(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLineWidthx29333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLineWidthx29333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadIdentity29334;
		 void javax.microedition.khronos.opengles.GL10.glLoadIdentity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLoadIdentity29334);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLoadIdentity29334);
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf29335;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf29335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf29335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf29336;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf29336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf29336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx29337;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx29337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx29337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx29338;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx29338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx29338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLogicOp29339;
		 void javax.microedition.khronos.opengles.GL10.glLogicOp(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLogicOp29339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLogicOp29339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialf29340;
		 void javax.microedition.khronos.opengles.GL10.glMaterialf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialf29340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialf29340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv29341;
		 void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialfv29341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialfv29341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv29342;
		 void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialfv29342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialfv29342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialx29343;
		 void javax.microedition.khronos.opengles.GL10.glMaterialx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialx29343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialx29343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv29344;
		 void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialxv29344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialxv29344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv29345;
		 void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialxv29345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialxv29345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixMode29346;
		 void javax.microedition.khronos.opengles.GL10.glMatrixMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMatrixMode29346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMatrixMode29346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf29347;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixf(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf29347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf29347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf29348;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixf(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf29348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf29348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx29349;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixx(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx29349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx29349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx29350;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixx(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx29350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx29350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4f29351;
		 void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4f29351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4f29351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4x29352;
		 void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4x29352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4x29352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3f29353;
		 void javax.microedition.khronos.opengles.GL10.glNormal3f(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glNormal3f29353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glNormal3f29353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3x29354;
		 void javax.microedition.khronos.opengles.GL10.glNormal3x(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glNormal3x29354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glNormal3x29354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer29355;
		 void javax.microedition.khronos.opengles.GL10.glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glNormalPointer29355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glNormalPointer29355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthof29356;
		 void javax.microedition.khronos.opengles.GL10.glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glOrthof29356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glOrthof29356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthox29357;
		 void javax.microedition.khronos.opengles.GL10.glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glOrthox29357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glOrthox29357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glPixelStorei29358;
		 void javax.microedition.khronos.opengles.GL10.glPixelStorei(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPixelStorei29358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPixelStorei29358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSize29359;
		 void javax.microedition.khronos.opengles.GL10.glPointSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointSize29359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointSize29359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizex29360;
		 void javax.microedition.khronos.opengles.GL10.glPointSizex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointSizex29360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointSizex29360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffset29361;
		 void javax.microedition.khronos.opengles.GL10.glPolygonOffset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPolygonOffset29361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPolygonOffset29361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffsetx29362;
		 void javax.microedition.khronos.opengles.GL10.glPolygonOffsetx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPolygonOffsetx29362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPolygonOffsetx29362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPopMatrix29363;
		 void javax.microedition.khronos.opengles.GL10.glPopMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPopMatrix29363);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPopMatrix29363);
		}
		internal static global::MonoJavaBridge.MethodId _glPushMatrix29364;
		 void javax.microedition.khronos.opengles.GL10.glPushMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPushMatrix29364);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPushMatrix29364);
		}
		internal static global::MonoJavaBridge.MethodId _glReadPixels29365;
		 void javax.microedition.khronos.opengles.GL10.glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glReadPixels29365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glReadPixels29365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatef29366;
		 void javax.microedition.khronos.opengles.GL10.glRotatef(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glRotatef29366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glRotatef29366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatex29367;
		 void javax.microedition.khronos.opengles.GL10.glRotatex(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glRotatex29367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glRotatex29367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoverage29368;
		 void javax.microedition.khronos.opengles.GL10.glSampleCoverage(float arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glSampleCoverage29368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glSampleCoverage29368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoveragex29369;
		 void javax.microedition.khronos.opengles.GL10.glSampleCoveragex(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glSampleCoveragex29369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glSampleCoveragex29369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glScalef29370;
		 void javax.microedition.khronos.opengles.GL10.glScalef(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glScalef29370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glScalef29370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScalex29371;
		 void javax.microedition.khronos.opengles.GL10.glScalex(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glScalex29371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glScalex29371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScissor29372;
		 void javax.microedition.khronos.opengles.GL10.glScissor(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glScissor29372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glScissor29372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glShadeModel29373;
		 void javax.microedition.khronos.opengles.GL10.glShadeModel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glShadeModel29373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glShadeModel29373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilFunc29374;
		 void javax.microedition.khronos.opengles.GL10.glStencilFunc(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glStencilFunc29374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glStencilFunc29374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilMask29375;
		 void javax.microedition.khronos.opengles.GL10.glStencilMask(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glStencilMask29375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glStencilMask29375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp29376;
		 void javax.microedition.khronos.opengles.GL10.glStencilOp(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glStencilOp29376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glStencilOp29376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer29377;
		 void javax.microedition.khronos.opengles.GL10.glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer29377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer29377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvf29378;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvf29378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvf29378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv29379;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv29379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv29379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv29380;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv29380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv29380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvx29381;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvx29381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvx29381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv29382;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv29382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv29382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv29383;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv29383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv29383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexImage2D29384;
		 void javax.microedition.khronos.opengles.GL10.glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexImage2D29384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexImage2D29384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf29385;
		 void javax.microedition.khronos.opengles.GL10.glTexParameterf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterf29385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterf29385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterx29386;
		 void javax.microedition.khronos.opengles.GL10.glTexParameterx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterx29386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterx29386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexSubImage2D29387;
		 void javax.microedition.khronos.opengles.GL10.glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexSubImage2D29387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexSubImage2D29387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatef29388;
		 void javax.microedition.khronos.opengles.GL10.glTranslatef(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTranslatef29388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTranslatef29388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatex29389;
		 void javax.microedition.khronos.opengles.GL10.glTranslatex(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTranslatex29389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTranslatex29389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer29390;
		 void javax.microedition.khronos.opengles.GL10.glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glVertexPointer29390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glVertexPointer29390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glViewport29391;
		 void javax.microedition.khronos.opengles.GL10.glViewport(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glViewport29391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glViewport29391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL11_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL11"));
			global::javax.microedition.khronos.opengles.GL11_._glColorPointer29201 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorPointer", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glDrawElements29202 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawElements", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glNormalPointer29203 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormalPointer", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer29204 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexCoordPointer", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glVertexPointer29205 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glVertexPointer", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glBindBuffer29206 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBindBuffer", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glBufferData29207 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V");
			global::javax.microedition.khronos.opengles.GL11_._glBufferSubData29208 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glClipPlanef29209 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glClipPlanef29210 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanef", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glClipPlanex29211 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanex", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glClipPlanex29212 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanex", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glColor4ub29213 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4ub", "(BBBB)V");
			global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers29214 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteBuffers", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers29215 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGenBuffers29216 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenBuffers", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGenBuffers29217 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv29218 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBooleanv", "(I[ZI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv29219 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv29220 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBufferParameteriv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv29221 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef29222 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanef", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef29223 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex29224 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanex", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex29225 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanex", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetFixedv29226 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFixedv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetFixedv29227 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFixedv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetFloatv29228 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFloatv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetFloatv29229 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetLightfv29230 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetLightfv29231 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetLightxv29232 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetLightxv29233 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv29234 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv29235 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv29236 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv29237 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv29238 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnviv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv29239 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnviv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv29240 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnvxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv29241 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv29242 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv29243 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv29244 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameteriv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv29245 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv29246 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv29247 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glIsBuffer29248 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsBuffer", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11_._glIsEnabled29249 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsEnabled", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11_._glIsTexture29250 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsTexture", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterf29251 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterf", "(IF)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv29252 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterfv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv29253 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterfv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterx29254 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterx", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv29255 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterxv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv29256 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterxv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointSizePointerOES29257 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSizePointerOES", "(IILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvi29258 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvi", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnviv29259 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnviv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnviv29260 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnviv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv29261 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv29262 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameteri29263 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteri", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv29264 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteriv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv29265 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv29266 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv29267 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetPointerv29268 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetPointerv", "(I[Ljava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glActiveTexture29269 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glActiveTexture", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glAlphaFunc29270 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glAlphaFunc", "(IF)V");
			global::javax.microedition.khronos.opengles.GL11_._glAlphaFuncx29271 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glAlphaFuncx", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glBindTexture29272 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBindTexture", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glBlendFunc29273 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBlendFunc", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glClear29274 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClear", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glClearColor29275 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearColor", "(FFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glClearColorx29276 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearColorx", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glClearDepthf29277 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearDepthf", "(F)V");
			global::javax.microedition.khronos.opengles.GL11_._glClearDepthx29278 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearDepthx", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glClearStencil29279 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearStencil", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glClientActiveTexture29280 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClientActiveTexture", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glColor4f29281 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4f", "(FFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glColor4x29282 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4x", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glColorMask29283 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorMask", "(ZZZZ)V");
			global::javax.microedition.khronos.opengles.GL11_._glColorPointer29284 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glCompressedTexImage2D29285 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glCompressedTexSubImage2D29286 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glCopyTexImage2D29287 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glCopyTexSubImage2D29288 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glCullFace29289 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCullFace", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures29290 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteTextures", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures29291 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glDepthFunc29292 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthFunc", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glDepthMask29293 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthMask", "(Z)V");
			global::javax.microedition.khronos.opengles.GL11_._glDepthRangef29294 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthRangef", "(FF)V");
			global::javax.microedition.khronos.opengles.GL11_._glDepthRangex29295 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthRangex", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glDisable29296 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDisable", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glDisableClientState29297 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDisableClientState", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glDrawArrays29298 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawArrays", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glDrawElements29299 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glEnable29300 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glEnable", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glEnableClientState29301 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glEnableClientState", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glFinish29302 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFinish", "()V");
			global::javax.microedition.khronos.opengles.GL11_._glFlush29303 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFlush", "()V");
			global::javax.microedition.khronos.opengles.GL11_._glFogf29304 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogf", "(IF)V");
			global::javax.microedition.khronos.opengles.GL11_._glFogfv29305 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogfv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glFogfv29306 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glFogx29307 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogx", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glFogxv29308 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogxv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glFogxv29309 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glFrontFace29310 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrontFace", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glFrustumf29311 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrustumf", "(FFFFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glFrustumx29312 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrustumx", "(IIIIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glGenTextures29313 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenTextures", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGenTextures29314 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetError29315 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetError", "()I");
			global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv29316 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetIntegerv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv29317 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetString29318 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetString", "(I)Ljava/lang/String;");
			global::javax.microedition.khronos.opengles.GL11_._glHint29319 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glHint", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelf29320 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelf", "(IF)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelfv29321 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelfv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelfv29322 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelx29323 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelx", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelxv29324 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelxv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelxv29325 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightf29326 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightfv29327 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightfv29328 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightx29329 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightxv29330 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightxv29331 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLineWidth29332 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLineWidth", "(F)V");
			global::javax.microedition.khronos.opengles.GL11_._glLineWidthx29333 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLineWidthx", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glLoadIdentity29334 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadIdentity", "()V");
			global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf29335 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixf", "([FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf29336 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx29337 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixx", "([II)V");
			global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx29338 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLogicOp29339 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLogicOp", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialf29340 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialfv29341 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialfv29342 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialx29343 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialxv29344 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialxv29345 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glMatrixMode29346 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMatrixMode", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf29347 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixf", "([FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf29348 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx29349 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixx", "([II)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx29350 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4f29351 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultiTexCoord4f", "(IFFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4x29352 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultiTexCoord4x", "(IIIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glNormal3f29353 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormal3f", "(FFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glNormal3x29354 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormal3x", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glNormalPointer29355 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glOrthof29356 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glOrthof", "(FFFFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glOrthox29357 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glOrthox", "(IIIIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glPixelStorei29358 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPixelStorei", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointSize29359 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSize", "(F)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointSizex29360 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSizex", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glPolygonOffset29361 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPolygonOffset", "(FF)V");
			global::javax.microedition.khronos.opengles.GL11_._glPolygonOffsetx29362 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPolygonOffsetx", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glPopMatrix29363 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPopMatrix", "()V");
			global::javax.microedition.khronos.opengles.GL11_._glPushMatrix29364 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPushMatrix", "()V");
			global::javax.microedition.khronos.opengles.GL11_._glReadPixels29365 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glRotatef29366 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glRotatef", "(FFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glRotatex29367 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glRotatex", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glSampleCoverage29368 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glSampleCoverage", "(FZ)V");
			global::javax.microedition.khronos.opengles.GL11_._glSampleCoveragex29369 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glSampleCoveragex", "(IZ)V");
			global::javax.microedition.khronos.opengles.GL11_._glScalef29370 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScalef", "(FFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glScalex29371 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScalex", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glScissor29372 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScissor", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glShadeModel29373 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glShadeModel", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glStencilFunc29374 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilFunc", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glStencilMask29375 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilMask", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glStencilOp29376 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilOp", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer29377 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvf29378 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv29379 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv29380 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvx29381 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv29382 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv29383 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexImage2D29384 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterf29385 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterx29386 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexSubImage2D29387 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTranslatef29388 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTranslatef", "(FFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glTranslatex29389 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTranslatex", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glVertexPointer29390 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glViewport29391 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glViewport", "(IIII)V");
		}
	}
}
