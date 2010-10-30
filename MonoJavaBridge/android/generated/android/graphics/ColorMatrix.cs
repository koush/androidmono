namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ColorMatrix : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ColorMatrix(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new float[] Array
		{
			get
			{
				return getArray();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual float[] getArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<float>(this, global::android.graphics.ColorMatrix.staticClass, "getArray", "()[F", ref global::android.graphics.ColorMatrix._m0) as float[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void set(android.graphics.ColorMatrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "set", "(Landroid/graphics/ColorMatrix;)V", ref global::android.graphics.ColorMatrix._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void set(float[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "set", "([F)V", ref global::android.graphics.ColorMatrix._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "reset", "()V", ref global::android.graphics.ColorMatrix._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "setScale", "(FFFF)V", ref global::android.graphics.ColorMatrix._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setRotate(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "setRotate", "(IF)V", ref global::android.graphics.ColorMatrix._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setConcat(android.graphics.ColorMatrix arg0, android.graphics.ColorMatrix arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "setConcat", "(Landroid/graphics/ColorMatrix;Landroid/graphics/ColorMatrix;)V", ref global::android.graphics.ColorMatrix._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void preConcat(android.graphics.ColorMatrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "preConcat", "(Landroid/graphics/ColorMatrix;)V", ref global::android.graphics.ColorMatrix._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void postConcat(android.graphics.ColorMatrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "postConcat", "(Landroid/graphics/ColorMatrix;)V", ref global::android.graphics.ColorMatrix._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Saturation
		{
			set
			{
				setSaturation(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setSaturation(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "setSaturation", "(F)V", ref global::android.graphics.ColorMatrix._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setRGB2YUV()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "setRGB2YUV", "()V", ref global::android.graphics.ColorMatrix._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setYUV2RGB()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, "setYUV2RGB", "()V", ref global::android.graphics.ColorMatrix._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public ColorMatrix() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._m12.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._m12 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._m12);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public ColorMatrix(float[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._m13.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._m13 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "([F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public ColorMatrix(android.graphics.ColorMatrix arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._m14.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._m14 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "(Landroid/graphics/ColorMatrix;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ColorMatrix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ColorMatrix.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ColorMatrix"));
		}
		internal static void InitJNI()
		{
		}
	}
}
