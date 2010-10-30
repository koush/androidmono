namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Movie : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Movie(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque5365;
		public virtual bool isOpaque()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._isOpaque5365.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._isOpaque5365 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "isOpaque", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._isOpaque5365);
		}
		public new int Time
		{
			set
			{
				setTime(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTime5366;
		public virtual bool setTime(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._setTime5366.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._setTime5366 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "setTime", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._setTime5366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _duration5367;
		public virtual int duration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._duration5367.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._duration5367 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "duration", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._duration5367);
		}
		internal static global::MonoJavaBridge.MethodId _height5368;
		public virtual int height()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._height5368.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._height5368 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "height", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._height5368);
		}
		internal static global::MonoJavaBridge.MethodId _width5369;
		public virtual int width()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._width5369.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._width5369 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "width", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._width5369);
		}
		internal static global::MonoJavaBridge.MethodId _draw5370;
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._draw5370.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._draw5370 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FF)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._draw5370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw5371;
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2, android.graphics.Paint arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._draw5371.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._draw5371 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FFLandroid/graphics/Paint;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._draw5371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _decodeStream5372;
		public static global::android.graphics.Movie decodeStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._decodeStream5372.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._decodeStream5372 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Movie;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeStream5372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		internal static global::MonoJavaBridge.MethodId _decodeByteArray5373;
		public static global::android.graphics.Movie decodeByteArray(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._decodeByteArray5373.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._decodeByteArray5373 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Movie;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeByteArray5373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Movie;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFile5374;
		public static global::android.graphics.Movie decodeFile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._decodeFile5374.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._decodeFile5374 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Movie;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeFile5374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		static Movie()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Movie.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Movie"));
		}
		internal static void InitJNI()
		{
		}
	}
}
