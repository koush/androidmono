namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Picture : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Picture()
		{
			InitJNI();
		}
		protected Picture(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize3603;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._finalize3603);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._finalize3603);
		}
		internal static global::MonoJavaBridge.MethodId _draw3604;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._draw3604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._draw3604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFromStream3605;
		public static global::android.graphics.Picture createFromStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Picture.staticClass, global::android.graphics.Picture._createFromStream3605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Picture;
		}
		internal static global::MonoJavaBridge.MethodId _getWidth3606;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Picture._getWidth3606);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._getWidth3606);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight3607;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Picture._getHeight3607);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._getHeight3607);
		}
		internal static global::MonoJavaBridge.MethodId _beginRecording3608;
		public virtual global::android.graphics.Canvas beginRecording(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Picture._beginRecording3608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Canvas;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._beginRecording3608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _endRecording3609;
		public virtual void endRecording() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._endRecording3609);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._endRecording3609);
		}
		internal static global::MonoJavaBridge.MethodId _writeToStream3610;
		public virtual void writeToStream(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._writeToStream3610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._writeToStream3610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Picture3611;
		public Picture()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Picture.staticClass, global::android.graphics.Picture._Picture3611);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Picture3612;
		public Picture(android.graphics.Picture arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Picture.staticClass, global::android.graphics.Picture._Picture3612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Picture.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Picture"));
			global::android.graphics.Picture._finalize3603 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "finalize", "()V");
			global::android.graphics.Picture._draw3604 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.Picture._createFromStream3605 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Picture.staticClass, "createFromStream", "(Ljava/io/InputStream;)Landroid/graphics/Picture;");
			global::android.graphics.Picture._getWidth3606 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "getWidth", "()I");
			global::android.graphics.Picture._getHeight3607 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "getHeight", "()I");
			global::android.graphics.Picture._beginRecording3608 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "beginRecording", "(II)Landroid/graphics/Canvas;");
			global::android.graphics.Picture._endRecording3609 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "endRecording", "()V");
			global::android.graphics.Picture._writeToStream3610 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "writeToStream", "(Ljava/io/OutputStream;)V");
			global::android.graphics.Picture._Picture3611 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "<init>", "()V");
			global::android.graphics.Picture._Picture3612 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "<init>", "(Landroid/graphics/Picture;)V");
		}
	}
}
