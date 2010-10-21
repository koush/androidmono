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
		internal static global::MonoJavaBridge.MethodId _finalize5566;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._finalize5566);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._finalize5566);
		}
		internal static global::MonoJavaBridge.MethodId _draw5567;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._draw5567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._draw5567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFromStream5568;
		public static global::android.graphics.Picture createFromStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Picture.staticClass, global::android.graphics.Picture._createFromStream5568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Picture;
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth5569;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Picture._getWidth5569);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._getWidth5569);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight5570;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Picture._getHeight5570);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._getHeight5570);
		}
		internal static global::MonoJavaBridge.MethodId _beginRecording5571;
		public virtual global::android.graphics.Canvas beginRecording(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Picture._beginRecording5571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Canvas;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._beginRecording5571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _endRecording5572;
		public virtual void endRecording() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._endRecording5572);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._endRecording5572);
		}
		internal static global::MonoJavaBridge.MethodId _writeToStream5573;
		public virtual void writeToStream(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._writeToStream5573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._writeToStream5573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Picture5574;
		public Picture()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Picture.staticClass, global::android.graphics.Picture._Picture5574);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Picture5575;
		public Picture(android.graphics.Picture arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Picture.staticClass, global::android.graphics.Picture._Picture5575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Picture.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Picture"));
			global::android.graphics.Picture._finalize5566 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "finalize", "()V");
			global::android.graphics.Picture._draw5567 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.Picture._createFromStream5568 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Picture.staticClass, "createFromStream", "(Ljava/io/InputStream;)Landroid/graphics/Picture;");
			global::android.graphics.Picture._getWidth5569 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "getWidth", "()I");
			global::android.graphics.Picture._getHeight5570 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "getHeight", "()I");
			global::android.graphics.Picture._beginRecording5571 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "beginRecording", "(II)Landroid/graphics/Canvas;");
			global::android.graphics.Picture._endRecording5572 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "endRecording", "()V");
			global::android.graphics.Picture._writeToStream5573 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "writeToStream", "(Ljava/io/OutputStream;)V");
			global::android.graphics.Picture._Picture5574 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "<init>", "()V");
			global::android.graphics.Picture._Picture5575 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "<init>", "(Landroid/graphics/Picture;)V");
		}
	}
}
