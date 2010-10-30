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
		internal static global::MonoJavaBridge.MethodId _getArray5241;
		public virtual float[] getArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._getArray5241.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._getArray5241 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "getArray", "()[F");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<float>(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._getArray5241) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _set5242;
		public virtual void set(android.graphics.ColorMatrix arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._set5242.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._set5242 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "set", "(Landroid/graphics/ColorMatrix;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._set5242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set5243;
		public virtual void set(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._set5243.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._set5243 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "set", "([F)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._set5243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset5244;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._reset5244.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._reset5244 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "reset", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._reset5244);
		}
		internal static global::MonoJavaBridge.MethodId _setScale5245;
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._setScale5245.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._setScale5245 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setScale", "(FFFF)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setScale5245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setRotate5246;
		public virtual void setRotate(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._setRotate5246.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._setRotate5246 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setRotate", "(IF)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setRotate5246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setConcat5247;
		public virtual void setConcat(android.graphics.ColorMatrix arg0, android.graphics.ColorMatrix arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._setConcat5247.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._setConcat5247 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setConcat", "(Landroid/graphics/ColorMatrix;Landroid/graphics/ColorMatrix;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setConcat5247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preConcat5248;
		public virtual void preConcat(android.graphics.ColorMatrix arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._preConcat5248.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._preConcat5248 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "preConcat", "(Landroid/graphics/ColorMatrix;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._preConcat5248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postConcat5249;
		public virtual void postConcat(android.graphics.ColorMatrix arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._postConcat5249.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._postConcat5249 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "postConcat", "(Landroid/graphics/ColorMatrix;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._postConcat5249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Saturation
		{
			set
			{
				setSaturation(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSaturation5250;
		public virtual void setSaturation(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._setSaturation5250.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._setSaturation5250 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setSaturation", "(F)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setSaturation5250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRGB2YUV5251;
		public virtual void setRGB2YUV()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._setRGB2YUV5251.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._setRGB2YUV5251 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setRGB2YUV", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setRGB2YUV5251);
		}
		internal static global::MonoJavaBridge.MethodId _setYUV2RGB5252;
		public virtual void setYUV2RGB()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._setYUV2RGB5252.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._setYUV2RGB5252 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setYUV2RGB", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setYUV2RGB5252);
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrix5253;
		public ColorMatrix() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._ColorMatrix5253.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._ColorMatrix5253 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix5253);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrix5254;
		public ColorMatrix(float[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._ColorMatrix5254.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._ColorMatrix5254 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "([F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix5254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrix5255;
		public ColorMatrix(android.graphics.ColorMatrix arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrix._ColorMatrix5255.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrix._ColorMatrix5255 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "(Landroid/graphics/ColorMatrix;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix5255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
