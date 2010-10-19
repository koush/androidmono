namespace javax.microedition.khronos.opengles
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.opengles.GL11_))]
	public interface GL11 : GL10
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
		internal static global::MonoJavaBridge.MethodId _glColorPointer22994;
		 void javax.microedition.khronos.opengles.GL11.glColorPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColorPointer22994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColorPointer22994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements22995;
		 void javax.microedition.khronos.opengles.GL11.glDrawElements(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDrawElements22995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDrawElements22995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer22996;
		 void javax.microedition.khronos.opengles.GL11.glNormalPointer(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glNormalPointer22996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glNormalPointer22996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer22997;
		 void javax.microedition.khronos.opengles.GL11.glTexCoordPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer22997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer22997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer22998;
		 void javax.microedition.khronos.opengles.GL11.glVertexPointer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glVertexPointer22998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glVertexPointer22998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBindBuffer22999;
		 void javax.microedition.khronos.opengles.GL11.glBindBuffer(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glBindBuffer22999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glBindBuffer22999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferData23000;
		 void javax.microedition.khronos.opengles.GL11.glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glBufferData23000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glBufferData23000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBufferSubData23001;
		 void javax.microedition.khronos.opengles.GL11.glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glBufferSubData23001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glBufferSubData23001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanef23002;
		 void javax.microedition.khronos.opengles.GL11.glClipPlanef(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClipPlanef23002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClipPlanef23002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanef23003;
		 void javax.microedition.khronos.opengles.GL11.glClipPlanef(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClipPlanef23003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClipPlanef23003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanex23004;
		 void javax.microedition.khronos.opengles.GL11.glClipPlanex(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClipPlanex23004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClipPlanex23004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanex23005;
		 void javax.microedition.khronos.opengles.GL11.glClipPlanex(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClipPlanex23005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClipPlanex23005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4ub23006;
		 void javax.microedition.khronos.opengles.GL11.glColor4ub(byte arg0, byte arg1, byte arg2, byte arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColor4ub23006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColor4ub23006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers23007;
		 void javax.microedition.khronos.opengles.GL11.glDeleteBuffers(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers23007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers23007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteBuffers23008;
		 void javax.microedition.khronos.opengles.GL11.glDeleteBuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers23008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers23008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers23009;
		 void javax.microedition.khronos.opengles.GL11.glGenBuffers(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGenBuffers23009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGenBuffers23009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenBuffers23010;
		 void javax.microedition.khronos.opengles.GL11.glGenBuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGenBuffers23010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGenBuffers23010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv23011;
		 void javax.microedition.khronos.opengles.GL11.glGetBooleanv(int arg0, bool[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv23011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv23011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBooleanv23012;
		 void javax.microedition.khronos.opengles.GL11.glGetBooleanv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv23012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv23012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv23013;
		 void javax.microedition.khronos.opengles.GL11.glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv23013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv23013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetBufferParameteriv23014;
		 void javax.microedition.khronos.opengles.GL11.glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv23014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv23014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanef23015;
		 void javax.microedition.khronos.opengles.GL11.glGetClipPlanef(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef23015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef23015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanef23016;
		 void javax.microedition.khronos.opengles.GL11.glGetClipPlanef(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef23016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef23016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanex23017;
		 void javax.microedition.khronos.opengles.GL11.glGetClipPlanex(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex23017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex23017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanex23018;
		 void javax.microedition.khronos.opengles.GL11.glGetClipPlanex(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex23018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex23018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedv23019;
		 void javax.microedition.khronos.opengles.GL11.glGetFixedv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetFixedv23019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetFixedv23019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedv23020;
		 void javax.microedition.khronos.opengles.GL11.glGetFixedv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetFixedv23020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetFixedv23020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv23021;
		 void javax.microedition.khronos.opengles.GL11.glGetFloatv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetFloatv23021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetFloatv23021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFloatv23022;
		 void javax.microedition.khronos.opengles.GL11.glGetFloatv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetFloatv23022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetFloatv23022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightfv23023;
		 void javax.microedition.khronos.opengles.GL11.glGetLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetLightfv23023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetLightfv23023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightfv23024;
		 void javax.microedition.khronos.opengles.GL11.glGetLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetLightfv23024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetLightfv23024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxv23025;
		 void javax.microedition.khronos.opengles.GL11.glGetLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetLightxv23025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetLightxv23025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxv23026;
		 void javax.microedition.khronos.opengles.GL11.glGetLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetLightxv23026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetLightxv23026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialfv23027;
		 void javax.microedition.khronos.opengles.GL11.glGetMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv23027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv23027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialfv23028;
		 void javax.microedition.khronos.opengles.GL11.glGetMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv23028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv23028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxv23029;
		 void javax.microedition.khronos.opengles.GL11.glGetMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv23029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv23029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxv23030;
		 void javax.microedition.khronos.opengles.GL11.glGetMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv23030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv23030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnviv23031;
		 void javax.microedition.khronos.opengles.GL11.glGetTexEnviv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv23031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv23031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnviv23032;
		 void javax.microedition.khronos.opengles.GL11.glGetTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv23032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv23032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxv23033;
		 void javax.microedition.khronos.opengles.GL11.glGetTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv23033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv23033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxv23034;
		 void javax.microedition.khronos.opengles.GL11.glGetTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv23034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv23034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv23035;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv23035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv23035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterfv23036;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv23036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv23036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv23037;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv23037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv23037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameteriv23038;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv23038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv23038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxv23039;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv23039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv23039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxv23040;
		 void javax.microedition.khronos.opengles.GL11.glGetTexParameterxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv23040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv23040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glIsBuffer23041;
		 bool javax.microedition.khronos.opengles.GL11.glIsBuffer(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glIsBuffer23041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glIsBuffer23041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsEnabled23042;
		 bool javax.microedition.khronos.opengles.GL11.glIsEnabled(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glIsEnabled23042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glIsEnabled23042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glIsTexture23043;
		 bool javax.microedition.khronos.opengles.GL11.glIsTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glIsTexture23043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glIsTexture23043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterf23044;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterf23044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterf23044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterfv23045;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv23045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv23045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterfv23046;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv23046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv23046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterx23047;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterx23047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterx23047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxv23048;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv23048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv23048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxv23049;
		 void javax.microedition.khronos.opengles.GL11.glPointParameterxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv23049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv23049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizePointerOES23050;
		 void javax.microedition.khronos.opengles.GL11.glPointSizePointerOES(int arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointSizePointerOES23050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointSizePointerOES23050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvi23051;
		 void javax.microedition.khronos.opengles.GL11.glTexEnvi(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvi23051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvi23051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnviv23052;
		 void javax.microedition.khronos.opengles.GL11.glTexEnviv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnviv23052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnviv23052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnviv23053;
		 void javax.microedition.khronos.opengles.GL11.glTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnviv23053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnviv23053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv23054;
		 void javax.microedition.khronos.opengles.GL11.glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv23054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv23054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterfv23055;
		 void javax.microedition.khronos.opengles.GL11.glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv23055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv23055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteri23056;
		 void javax.microedition.khronos.opengles.GL11.glTexParameteri(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameteri23056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameteri23056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv23057;
		 void javax.microedition.khronos.opengles.GL11.glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv23057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv23057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameteriv23058;
		 void javax.microedition.khronos.opengles.GL11.glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv23058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv23058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxv23059;
		 void javax.microedition.khronos.opengles.GL11.glTexParameterxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv23059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv23059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxv23060;
		 void javax.microedition.khronos.opengles.GL11.glTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv23060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv23060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetPointerv23061;
		 void javax.microedition.khronos.opengles.GL11.glGetPointerv(int arg0, java.nio.Buffer[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetPointerv23061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetPointerv23061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glActiveTexture23062;
		 void javax.microedition.khronos.opengles.GL10.glActiveTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glActiveTexture23062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glActiveTexture23062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFunc23063;
		 void javax.microedition.khronos.opengles.GL10.glAlphaFunc(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glAlphaFunc23063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glAlphaFunc23063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFuncx23064;
		 void javax.microedition.khronos.opengles.GL10.glAlphaFuncx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glAlphaFuncx23064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glAlphaFuncx23064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBindTexture23065;
		 void javax.microedition.khronos.opengles.GL10.glBindTexture(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glBindTexture23065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glBindTexture23065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFunc23066;
		 void javax.microedition.khronos.opengles.GL10.glBlendFunc(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glBlendFunc23066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glBlendFunc23066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClear23067;
		 void javax.microedition.khronos.opengles.GL10.glClear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClear23067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClear23067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColor23068;
		 void javax.microedition.khronos.opengles.GL10.glClearColor(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClearColor23068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClearColor23068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColorx23069;
		 void javax.microedition.khronos.opengles.GL10.glClearColorx(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClearColorx23069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClearColorx23069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthf23070;
		 void javax.microedition.khronos.opengles.GL10.glClearDepthf(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClearDepthf23070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClearDepthf23070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthx23071;
		 void javax.microedition.khronos.opengles.GL10.glClearDepthx(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClearDepthx23071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClearDepthx23071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearStencil23072;
		 void javax.microedition.khronos.opengles.GL10.glClearStencil(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClearStencil23072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClearStencil23072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClientActiveTexture23073;
		 void javax.microedition.khronos.opengles.GL10.glClientActiveTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glClientActiveTexture23073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glClientActiveTexture23073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4f23074;
		 void javax.microedition.khronos.opengles.GL10.glColor4f(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColor4f23074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColor4f23074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4x23075;
		 void javax.microedition.khronos.opengles.GL10.glColor4x(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColor4x23075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColor4x23075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorMask23076;
		 void javax.microedition.khronos.opengles.GL10.glColorMask(bool arg0, bool arg1, bool arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColorMask23076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColorMask23076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorPointer23077;
		 void javax.microedition.khronos.opengles.GL10.glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glColorPointer23077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glColorPointer23077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D23078;
		 void javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glCompressedTexImage2D23078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glCompressedTexImage2D23078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexSubImage2D23079;
		 void javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glCompressedTexSubImage2D23079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glCompressedTexSubImage2D23079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D23080;
		 void javax.microedition.khronos.opengles.GL10.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glCopyTexImage2D23080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glCopyTexImage2D23080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexSubImage2D23081;
		 void javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glCopyTexSubImage2D23081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glCopyTexSubImage2D23081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCullFace23082;
		 void javax.microedition.khronos.opengles.GL10.glCullFace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glCullFace23082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glCullFace23082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures23083;
		 void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures23083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures23083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures23084;
		 void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures23084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures23084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthFunc23085;
		 void javax.microedition.khronos.opengles.GL10.glDepthFunc(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDepthFunc23085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDepthFunc23085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthMask23086;
		 void javax.microedition.khronos.opengles.GL10.glDepthMask(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDepthMask23086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDepthMask23086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangef23087;
		 void javax.microedition.khronos.opengles.GL10.glDepthRangef(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDepthRangef23087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDepthRangef23087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangex23088;
		 void javax.microedition.khronos.opengles.GL10.glDepthRangex(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDepthRangex23088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDepthRangex23088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDisable23089;
		 void javax.microedition.khronos.opengles.GL10.glDisable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDisable23089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDisable23089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDisableClientState23090;
		 void javax.microedition.khronos.opengles.GL10.glDisableClientState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDisableClientState23090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDisableClientState23090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawArrays23091;
		 void javax.microedition.khronos.opengles.GL10.glDrawArrays(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDrawArrays23091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDrawArrays23091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements23092;
		 void javax.microedition.khronos.opengles.GL10.glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glDrawElements23092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glDrawElements23092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable23093;
		 void javax.microedition.khronos.opengles.GL10.glEnable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glEnable23093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glEnable23093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEnableClientState23094;
		 void javax.microedition.khronos.opengles.GL10.glEnableClientState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glEnableClientState23094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glEnableClientState23094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFinish23095;
		 void javax.microedition.khronos.opengles.GL10.glFinish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFinish23095);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFinish23095);
		}
		internal static global::MonoJavaBridge.MethodId _glFlush23096;
		 void javax.microedition.khronos.opengles.GL10.glFlush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFlush23096);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFlush23096);
		}
		internal static global::MonoJavaBridge.MethodId _glFogf23097;
		 void javax.microedition.khronos.opengles.GL10.glFogf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogf23097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogf23097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv23098;
		 void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogfv23098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogfv23098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv23099;
		 void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogfv23099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogfv23099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogx23100;
		 void javax.microedition.khronos.opengles.GL10.glFogx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogx23100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogx23100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv23101;
		 void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogxv23101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogxv23101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv23102;
		 void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFogxv23102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFogxv23102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrontFace23103;
		 void javax.microedition.khronos.opengles.GL10.glFrontFace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFrontFace23103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFrontFace23103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumf23104;
		 void javax.microedition.khronos.opengles.GL10.glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFrustumf23104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFrustumf23104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumx23105;
		 void javax.microedition.khronos.opengles.GL10.glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glFrustumx23105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glFrustumx23105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures23106;
		 void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGenTextures23106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGenTextures23106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures23107;
		 void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGenTextures23107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGenTextures23107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetError23108;
		 int javax.microedition.khronos.opengles.GL10.glGetError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetError23108);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetError23108);
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv23109;
		 void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv23109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv23109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv23110;
		 void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv23110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv23110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetString23111;
		 global::java.lang.String javax.microedition.khronos.opengles.GL10.glGetString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glGetString23111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glGetString23111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _glHint23112;
		 void javax.microedition.khronos.opengles.GL10.glHint(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glHint23112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glHint23112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelf23113;
		 void javax.microedition.khronos.opengles.GL10.glLightModelf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelf23113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelf23113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv23114;
		 void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelfv23114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelfv23114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv23115;
		 void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelfv23115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelfv23115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelx23116;
		 void javax.microedition.khronos.opengles.GL10.glLightModelx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelx23116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelx23116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv23117;
		 void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelxv23117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelxv23117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv23118;
		 void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightModelxv23118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightModelxv23118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightf23119;
		 void javax.microedition.khronos.opengles.GL10.glLightf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightf23119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightf23119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv23120;
		 void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightfv23120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightfv23120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv23121;
		 void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightfv23121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightfv23121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightx23122;
		 void javax.microedition.khronos.opengles.GL10.glLightx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightx23122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightx23122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv23123;
		 void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightxv23123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightxv23123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv23124;
		 void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLightxv23124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLightxv23124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidth23125;
		 void javax.microedition.khronos.opengles.GL10.glLineWidth(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLineWidth23125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLineWidth23125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidthx23126;
		 void javax.microedition.khronos.opengles.GL10.glLineWidthx(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLineWidthx23126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLineWidthx23126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadIdentity23127;
		 void javax.microedition.khronos.opengles.GL10.glLoadIdentity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLoadIdentity23127);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLoadIdentity23127);
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf23128;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf23128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf23128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf23129;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf23129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf23129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx23130;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx23130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx23130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx23131;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx23131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx23131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLogicOp23132;
		 void javax.microedition.khronos.opengles.GL10.glLogicOp(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glLogicOp23132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glLogicOp23132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialf23133;
		 void javax.microedition.khronos.opengles.GL10.glMaterialf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialf23133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialf23133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv23134;
		 void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialfv23134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialfv23134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv23135;
		 void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialfv23135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialfv23135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialx23136;
		 void javax.microedition.khronos.opengles.GL10.glMaterialx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialx23136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialx23136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv23137;
		 void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialxv23137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialxv23137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv23138;
		 void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMaterialxv23138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMaterialxv23138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixMode23139;
		 void javax.microedition.khronos.opengles.GL10.glMatrixMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMatrixMode23139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMatrixMode23139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf23140;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixf(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf23140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf23140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf23141;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixf(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf23141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf23141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx23142;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixx(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx23142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx23142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx23143;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixx(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx23143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx23143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4f23144;
		 void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4f23144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4f23144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4x23145;
		 void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4x23145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4x23145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3f23146;
		 void javax.microedition.khronos.opengles.GL10.glNormal3f(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glNormal3f23146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glNormal3f23146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3x23147;
		 void javax.microedition.khronos.opengles.GL10.glNormal3x(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glNormal3x23147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glNormal3x23147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer23148;
		 void javax.microedition.khronos.opengles.GL10.glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glNormalPointer23148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glNormalPointer23148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthof23149;
		 void javax.microedition.khronos.opengles.GL10.glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glOrthof23149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glOrthof23149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthox23150;
		 void javax.microedition.khronos.opengles.GL10.glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glOrthox23150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glOrthox23150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glPixelStorei23151;
		 void javax.microedition.khronos.opengles.GL10.glPixelStorei(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPixelStorei23151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPixelStorei23151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSize23152;
		 void javax.microedition.khronos.opengles.GL10.glPointSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointSize23152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointSize23152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizex23153;
		 void javax.microedition.khronos.opengles.GL10.glPointSizex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPointSizex23153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPointSizex23153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffset23154;
		 void javax.microedition.khronos.opengles.GL10.glPolygonOffset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPolygonOffset23154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPolygonOffset23154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffsetx23155;
		 void javax.microedition.khronos.opengles.GL10.glPolygonOffsetx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPolygonOffsetx23155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPolygonOffsetx23155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPopMatrix23156;
		 void javax.microedition.khronos.opengles.GL10.glPopMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPopMatrix23156);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPopMatrix23156);
		}
		internal static global::MonoJavaBridge.MethodId _glPushMatrix23157;
		 void javax.microedition.khronos.opengles.GL10.glPushMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glPushMatrix23157);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glPushMatrix23157);
		}
		internal static global::MonoJavaBridge.MethodId _glReadPixels23158;
		 void javax.microedition.khronos.opengles.GL10.glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glReadPixels23158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glReadPixels23158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatef23159;
		 void javax.microedition.khronos.opengles.GL10.glRotatef(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glRotatef23159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glRotatef23159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatex23160;
		 void javax.microedition.khronos.opengles.GL10.glRotatex(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glRotatex23160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glRotatex23160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoverage23161;
		 void javax.microedition.khronos.opengles.GL10.glSampleCoverage(float arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glSampleCoverage23161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glSampleCoverage23161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoveragex23162;
		 void javax.microedition.khronos.opengles.GL10.glSampleCoveragex(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glSampleCoveragex23162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glSampleCoveragex23162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glScalef23163;
		 void javax.microedition.khronos.opengles.GL10.glScalef(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glScalef23163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glScalef23163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScalex23164;
		 void javax.microedition.khronos.opengles.GL10.glScalex(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glScalex23164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glScalex23164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScissor23165;
		 void javax.microedition.khronos.opengles.GL10.glScissor(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glScissor23165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glScissor23165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glShadeModel23166;
		 void javax.microedition.khronos.opengles.GL10.glShadeModel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glShadeModel23166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glShadeModel23166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilFunc23167;
		 void javax.microedition.khronos.opengles.GL10.glStencilFunc(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glStencilFunc23167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glStencilFunc23167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilMask23168;
		 void javax.microedition.khronos.opengles.GL10.glStencilMask(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glStencilMask23168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glStencilMask23168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp23169;
		 void javax.microedition.khronos.opengles.GL10.glStencilOp(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glStencilOp23169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glStencilOp23169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer23170;
		 void javax.microedition.khronos.opengles.GL10.glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer23170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer23170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvf23171;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvf23171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvf23171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv23172;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv23172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv23172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv23173;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv23173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv23173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvx23174;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvx23174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvx23174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv23175;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv23175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv23175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv23176;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv23176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv23176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexImage2D23177;
		 void javax.microedition.khronos.opengles.GL10.glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexImage2D23177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexImage2D23177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf23178;
		 void javax.microedition.khronos.opengles.GL10.glTexParameterf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterf23178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterf23178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterx23179;
		 void javax.microedition.khronos.opengles.GL10.glTexParameterx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexParameterx23179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexParameterx23179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexSubImage2D23180;
		 void javax.microedition.khronos.opengles.GL10.glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTexSubImage2D23180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTexSubImage2D23180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatef23181;
		 void javax.microedition.khronos.opengles.GL10.glTranslatef(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTranslatef23181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTranslatef23181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatex23182;
		 void javax.microedition.khronos.opengles.GL10.glTranslatex(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glTranslatex23182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glTranslatex23182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer23183;
		 void javax.microedition.khronos.opengles.GL10.glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glVertexPointer23183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glVertexPointer23183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glViewport23184;
		 void javax.microedition.khronos.opengles.GL10.glViewport(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_._glViewport23184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11_.staticClass, global::javax.microedition.khronos.opengles.GL11_._glViewport23184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL11_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL11"));
			global::javax.microedition.khronos.opengles.GL11_._glColorPointer22994 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorPointer", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glDrawElements22995 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawElements", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glNormalPointer22996 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormalPointer", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer22997 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexCoordPointer", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glVertexPointer22998 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glVertexPointer", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glBindBuffer22999 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBindBuffer", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glBufferData23000 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V");
			global::javax.microedition.khronos.opengles.GL11_._glBufferSubData23001 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glClipPlanef23002 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glClipPlanef23003 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanef", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glClipPlanex23004 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanex", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glClipPlanex23005 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClipPlanex", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glColor4ub23006 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4ub", "(BBBB)V");
			global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers23007 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteBuffers", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glDeleteBuffers23008 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGenBuffers23009 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenBuffers", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGenBuffers23010 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv23011 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBooleanv", "(I[ZI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetBooleanv23012 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv23013 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBufferParameteriv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetBufferParameteriv23014 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef23015 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanef", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanef23016 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex23017 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanex", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetClipPlanex23018 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetClipPlanex", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetFixedv23019 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFixedv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetFixedv23020 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFixedv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetFloatv23021 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFloatv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetFloatv23022 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetLightfv23023 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetLightfv23024 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetLightxv23025 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetLightxv23026 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetLightxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv23027 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetMaterialfv23028 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv23029 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetMaterialxv23030 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetMaterialxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv23031 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnviv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexEnviv23032 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnviv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv23033 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnvxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexEnvxv23034 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv23035 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterfv23036 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv23037 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameteriv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameteriv23038 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv23039 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetTexParameterxv23040 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetTexParameterxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glIsBuffer23041 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsBuffer", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11_._glIsEnabled23042 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsEnabled", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11_._glIsTexture23043 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glIsTexture", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterf23044 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterf", "(IF)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv23045 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterfv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterfv23046 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterfv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterx23047 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterx", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv23048 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterxv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointParameterxv23049 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointParameterxv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointSizePointerOES23050 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSizePointerOES", "(IILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvi23051 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvi", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnviv23052 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnviv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnviv23053 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnviv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv23054 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterfv23055 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameteri23056 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteri", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv23057 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteriv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameteriv23058 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv23059 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterxv23060 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetPointerv23061 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetPointerv", "(I[Ljava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glActiveTexture23062 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glActiveTexture", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glAlphaFunc23063 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glAlphaFunc", "(IF)V");
			global::javax.microedition.khronos.opengles.GL11_._glAlphaFuncx23064 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glAlphaFuncx", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glBindTexture23065 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBindTexture", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glBlendFunc23066 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glBlendFunc", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glClear23067 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClear", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glClearColor23068 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearColor", "(FFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glClearColorx23069 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearColorx", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glClearDepthf23070 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearDepthf", "(F)V");
			global::javax.microedition.khronos.opengles.GL11_._glClearDepthx23071 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearDepthx", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glClearStencil23072 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClearStencil", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glClientActiveTexture23073 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glClientActiveTexture", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glColor4f23074 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4f", "(FFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glColor4x23075 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColor4x", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glColorMask23076 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorMask", "(ZZZZ)V");
			global::javax.microedition.khronos.opengles.GL11_._glColorPointer23077 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glCompressedTexImage2D23078 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glCompressedTexSubImage2D23079 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glCopyTexImage2D23080 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glCopyTexSubImage2D23081 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glCullFace23082 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glCullFace", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures23083 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteTextures", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glDeleteTextures23084 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glDepthFunc23085 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthFunc", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glDepthMask23086 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthMask", "(Z)V");
			global::javax.microedition.khronos.opengles.GL11_._glDepthRangef23087 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthRangef", "(FF)V");
			global::javax.microedition.khronos.opengles.GL11_._glDepthRangex23088 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDepthRangex", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glDisable23089 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDisable", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glDisableClientState23090 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDisableClientState", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glDrawArrays23091 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawArrays", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glDrawElements23092 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glEnable23093 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glEnable", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glEnableClientState23094 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glEnableClientState", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glFinish23095 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFinish", "()V");
			global::javax.microedition.khronos.opengles.GL11_._glFlush23096 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFlush", "()V");
			global::javax.microedition.khronos.opengles.GL11_._glFogf23097 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogf", "(IF)V");
			global::javax.microedition.khronos.opengles.GL11_._glFogfv23098 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogfv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glFogfv23099 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glFogx23100 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogx", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glFogxv23101 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogxv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glFogxv23102 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glFrontFace23103 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrontFace", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glFrustumf23104 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrustumf", "(FFFFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glFrustumx23105 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glFrustumx", "(IIIIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glGenTextures23106 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenTextures", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGenTextures23107 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetError23108 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetError", "()I");
			global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv23109 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetIntegerv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetIntegerv23110 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glGetString23111 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glGetString", "(I)Ljava/lang/String;");
			global::javax.microedition.khronos.opengles.GL11_._glHint23112 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glHint", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelf23113 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelf", "(IF)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelfv23114 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelfv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelfv23115 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelx23116 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelx", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelxv23117 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelxv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightModelxv23118 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightf23119 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightfv23120 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightfv23121 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightx23122 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightxv23123 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glLightxv23124 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLineWidth23125 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLineWidth", "(F)V");
			global::javax.microedition.khronos.opengles.GL11_._glLineWidthx23126 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLineWidthx", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glLoadIdentity23127 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadIdentity", "()V");
			global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf23128 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixf", "([FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixf23129 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx23130 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixx", "([II)V");
			global::javax.microedition.khronos.opengles.GL11_._glLoadMatrixx23131 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glLogicOp23132 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glLogicOp", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialf23133 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialfv23134 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialfv23135 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialx23136 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialxv23137 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glMaterialxv23138 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glMatrixMode23139 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMatrixMode", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf23140 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixf", "([FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultMatrixf23141 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx23142 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixx", "([II)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultMatrixx23143 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4f23144 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultiTexCoord4f", "(IFFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glMultiTexCoord4x23145 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glMultiTexCoord4x", "(IIIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glNormal3f23146 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormal3f", "(FFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glNormal3x23147 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormal3x", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glNormalPointer23148 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glOrthof23149 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glOrthof", "(FFFFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glOrthox23150 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glOrthox", "(IIIIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glPixelStorei23151 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPixelStorei", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointSize23152 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSize", "(F)V");
			global::javax.microedition.khronos.opengles.GL11_._glPointSizex23153 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPointSizex", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glPolygonOffset23154 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPolygonOffset", "(FF)V");
			global::javax.microedition.khronos.opengles.GL11_._glPolygonOffsetx23155 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPolygonOffsetx", "(II)V");
			global::javax.microedition.khronos.opengles.GL11_._glPopMatrix23156 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPopMatrix", "()V");
			global::javax.microedition.khronos.opengles.GL11_._glPushMatrix23157 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glPushMatrix", "()V");
			global::javax.microedition.khronos.opengles.GL11_._glReadPixels23158 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glRotatef23159 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glRotatef", "(FFFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glRotatex23160 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glRotatex", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glSampleCoverage23161 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glSampleCoverage", "(FZ)V");
			global::javax.microedition.khronos.opengles.GL11_._glSampleCoveragex23162 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glSampleCoveragex", "(IZ)V");
			global::javax.microedition.khronos.opengles.GL11_._glScalef23163 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScalef", "(FFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glScalex23164 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScalex", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glScissor23165 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glScissor", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11_._glShadeModel23166 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glShadeModel", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glStencilFunc23167 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilFunc", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glStencilMask23168 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilMask", "(I)V");
			global::javax.microedition.khronos.opengles.GL11_._glStencilOp23169 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glStencilOp", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexCoordPointer23170 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvf23171 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv23172 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvfv23173 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvx23174 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv23175 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexEnvxv23176 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexImage2D23177 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterf23178 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexParameterx23179 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexParameterx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glTexSubImage2D23180 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glTranslatef23181 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTranslatef", "(FFF)V");
			global::javax.microedition.khronos.opengles.GL11_._glTranslatex23182 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glTranslatex", "(III)V");
			global::javax.microedition.khronos.opengles.GL11_._glVertexPointer23183 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11_._glViewport23184 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11_.staticClass, "glViewport", "(IIII)V");
		}
	}
}
