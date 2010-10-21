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
		internal static global::MonoJavaBridge.MethodId _isOpaque5346;
		public virtual bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Movie._isOpaque5346);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._isOpaque5346);
		}
		internal static global::MonoJavaBridge.MethodId _setTime5347;
		public virtual bool setTime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Movie._setTime5347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._setTime5347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _duration5348;
		public virtual int duration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Movie._duration5348);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._duration5348);
		}
		internal static global::MonoJavaBridge.MethodId _height5349;
		public virtual int height() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Movie._height5349);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._height5349);
		}
		internal static global::MonoJavaBridge.MethodId _width5350;
		public virtual int width() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Movie._width5350);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._width5350);
		}
		internal static global::MonoJavaBridge.MethodId _draw5351;
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Movie._draw5351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._draw5351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw5352;
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Movie._draw5352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._draw5352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _decodeStream5353;
		public static global::android.graphics.Movie decodeStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeStream5353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		internal static global::MonoJavaBridge.MethodId _decodeByteArray5354;
		public static global::android.graphics.Movie decodeByteArray(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeByteArray5354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Movie;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFile5355;
		public static global::android.graphics.Movie decodeFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeFile5355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Movie;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Movie.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Movie"));
			global::android.graphics.Movie._isOpaque5346 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "isOpaque", "()Z");
			global::android.graphics.Movie._setTime5347 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "setTime", "(I)Z");
			global::android.graphics.Movie._duration5348 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "duration", "()I");
			global::android.graphics.Movie._height5349 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "height", "()I");
			global::android.graphics.Movie._width5350 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "width", "()I");
			global::android.graphics.Movie._draw5351 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FF)V");
			global::android.graphics.Movie._draw5352 = @__env.GetMethodIDNoThrow(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Movie._decodeStream5353 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Movie;");
			global::android.graphics.Movie._decodeByteArray5354 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Movie;");
			global::android.graphics.Movie._decodeFile5355 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Movie.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Movie;");
		}
	}
}
