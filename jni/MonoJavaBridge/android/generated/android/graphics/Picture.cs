namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Picture : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Picture(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5585;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._finalize5585);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._finalize5585);
		}
		internal static global::MonoJavaBridge.MethodId _draw5586;
		public virtual void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._draw5586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._draw5586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFromStream5587;
		public static global::android.graphics.Picture createFromStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Picture.staticClass, global::android.graphics.Picture._createFromStream5587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Picture;
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth5588;
		public virtual int getWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Picture._getWidth5588);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._getWidth5588);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight5589;
		public virtual int getHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Picture._getHeight5589);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._getHeight5589);
		}
		internal static global::MonoJavaBridge.MethodId _beginRecording5590;
		public virtual global::android.graphics.Canvas beginRecording(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Picture._beginRecording5590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Canvas;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._beginRecording5590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _endRecording5591;
		public virtual void endRecording()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._endRecording5591);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._endRecording5591);
		}
		internal static global::MonoJavaBridge.MethodId _writeToStream5592;
		public virtual void writeToStream(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Picture._writeToStream5592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._writeToStream5592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Picture5593;
		public Picture() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Picture.staticClass, global::android.graphics.Picture._Picture5593);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Picture5594;
		public Picture(android.graphics.Picture arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Picture.staticClass, global::android.graphics.Picture._Picture5594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Picture()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Picture.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Picture"));
			global::android.graphics.Picture._finalize5585 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "finalize", "()V");
			global::android.graphics.Picture._draw5586 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.Picture._createFromStream5587 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Picture.staticClass, "createFromStream", "(Ljava/io/InputStream;)Landroid/graphics/Picture;");
			global::android.graphics.Picture._getWidth5588 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "getWidth", "()I");
			global::android.graphics.Picture._getHeight5589 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "getHeight", "()I");
			global::android.graphics.Picture._beginRecording5590 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "beginRecording", "(II)Landroid/graphics/Canvas;");
			global::android.graphics.Picture._endRecording5591 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "endRecording", "()V");
			global::android.graphics.Picture._writeToStream5592 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "writeToStream", "(Ljava/io/OutputStream;)V");
			global::android.graphics.Picture._Picture5593 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "<init>", "()V");
			global::android.graphics.Picture._Picture5594 = @__env.GetMethodIDNoThrow(global::android.graphics.Picture.staticClass, "<init>", "(Landroid/graphics/Picture;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
