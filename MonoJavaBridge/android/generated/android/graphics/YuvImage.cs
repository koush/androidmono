namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class YuvImage : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected YuvImage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.YuvImage.staticClass, "getWidth", "()I", ref global::android.graphics.YuvImage._m0);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.YuvImage.staticClass, "getHeight", "()I", ref global::android.graphics.YuvImage._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool compressToJpeg(android.graphics.Rect arg0, int arg1, java.io.OutputStream arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.YuvImage.staticClass, "compressToJpeg", "(Landroid/graphics/Rect;ILjava/io/OutputStream;)Z", ref global::android.graphics.YuvImage._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new byte[] YuvData
		{
			get
			{
				return getYuvData();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual byte[] getYuvData()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.graphics.YuvImage.staticClass, "getYuvData", "()[B", ref global::android.graphics.YuvImage._m3) as byte[];
		}
		public new int YuvFormat
		{
			get
			{
				return getYuvFormat();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getYuvFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.YuvImage.staticClass, "getYuvFormat", "()I", ref global::android.graphics.YuvImage._m4);
		}
		public new int[] Strides
		{
			get
			{
				return getStrides();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int[] getStrides()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.graphics.YuvImage.staticClass, "getStrides", "()[I", ref global::android.graphics.YuvImage._m5) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public YuvImage(byte[] arg0, int arg1, int arg2, int arg3, int[] arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.YuvImage._m6.native == global::System.IntPtr.Zero)
				global::android.graphics.YuvImage._m6 = @__env.GetMethodIDNoThrow(global::android.graphics.YuvImage.staticClass, "<init>", "([BIII[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static YuvImage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.YuvImage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/YuvImage"));
		}
		internal static void InitJNI()
		{
		}
	}
}
