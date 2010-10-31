namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Movie : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Movie(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool isOpaque()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Movie.staticClass, "isOpaque", "()Z", ref global::android.graphics.Movie._m0);
		}
		public new int Time
		{
			set
			{
				setTime(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool setTime(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Movie.staticClass, "setTime", "(I)Z", ref global::android.graphics.Movie._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int duration()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Movie.staticClass, "duration", "()I", ref global::android.graphics.Movie._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int height()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Movie.staticClass, "height", "()I", ref global::android.graphics.Movie._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int width()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Movie.staticClass, "width", "()I", ref global::android.graphics.Movie._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FF)V", ref global::android.graphics.Movie._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2, android.graphics.Paint arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FFLandroid/graphics/Paint;)V", ref global::android.graphics.Movie._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.graphics.Movie decodeStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._m7.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._m7 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Movie;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::android.graphics.Movie decodeByteArray(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._m8.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._m8 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Movie;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Movie;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::android.graphics.Movie decodeFile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Movie._m9.native == global::System.IntPtr.Zero)
				global::android.graphics.Movie._m9 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Movie;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		static Movie()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Movie.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Movie"));
		}
	}
}
