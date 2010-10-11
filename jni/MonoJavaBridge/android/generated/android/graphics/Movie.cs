namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Movie : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Movie()
		{
			InitJNI();
		}
		protected Movie(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isOpaque3394;
		public virtual bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Movie._isOpaque3394);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._isOpaque3394);
		}
		internal static global::MonoJavaBridge.MethodId _setTime3395;
		public virtual bool setTime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Movie._setTime3395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._setTime3395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _duration3396;
		public virtual int duration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Movie._duration3396);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._duration3396);
		}
		internal static global::MonoJavaBridge.MethodId _height3397;
		public virtual int height() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Movie._height3397);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._height3397);
		}
		internal static global::MonoJavaBridge.MethodId _width3398;
		public virtual int width() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Movie._width3398);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._width3398);
		}
		internal static global::MonoJavaBridge.MethodId _draw3399;
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Movie._draw3399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._draw3399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw3400;
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Movie._draw3400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._draw3400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _decodeStream3401;
		public static global::android.graphics.Movie decodeStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeStream3401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		internal static global::MonoJavaBridge.MethodId _decodeByteArray3402;
		public static global::android.graphics.Movie decodeByteArray(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeByteArray3402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Movie;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFile3403;
		public static global::android.graphics.Movie decodeFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeFile3403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Movie.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Movie"));
			global::android.graphics.Movie._isOpaque3394 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "isOpaque", "()Z");
			global::android.graphics.Movie._setTime3395 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "setTime", "(I)Z");
			global::android.graphics.Movie._duration3396 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "duration", "()I");
			global::android.graphics.Movie._height3397 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "height", "()I");
			global::android.graphics.Movie._width3398 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "width", "()I");
			global::android.graphics.Movie._draw3399 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FF)V");
			global::android.graphics.Movie._draw3400 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Movie._decodeStream3401 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Movie;");
			global::android.graphics.Movie._decodeByteArray3402 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Movie;");
			global::android.graphics.Movie._decodeFile3403 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Movie;");
		}
	}
}
