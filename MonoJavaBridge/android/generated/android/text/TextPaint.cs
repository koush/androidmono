namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextPaint : android.graphics.Paint
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TextPaint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void set(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.TextPaint.staticClass, "set", "(Landroid/text/TextPaint;)V", ref global::android.text.TextPaint._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public TextPaint() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextPaint._m1.native == global::System.IntPtr.Zero)
				global::android.text.TextPaint._m1 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._m1);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public TextPaint(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextPaint._m2.native == global::System.IntPtr.Zero)
				global::android.text.TextPaint._m2 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public TextPaint(android.graphics.Paint arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextPaint._m3.native == global::System.IntPtr.Zero)
				global::android.text.TextPaint._m3 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "(Landroid/graphics/Paint;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _bgColor5246;
		public int bgColor
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _bgColor5246);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _baselineShift5247;
		public int baselineShift
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _baselineShift5247);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _linkColor5248;
		public int linkColor
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _linkColor5248);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _drawableState5249;
		public int[] drawableState
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetObjectField(this.JvmHandle, _drawableState5249)) as int[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _density5250;
		public float density
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _density5250);
			}
			set
			{
			}
		}
		static TextPaint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.TextPaint.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextPaint"));
			global::android.text.TextPaint._bgColor5246 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "bgColor", "I");
			global::android.text.TextPaint._baselineShift5247 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "baselineShift", "I");
			global::android.text.TextPaint._linkColor5248 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "linkColor", "I");
			global::android.text.TextPaint._drawableState5249 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "drawableState", "[I");
			global::android.text.TextPaint._density5250 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "density", "F");
		}
		internal static void InitJNI()
		{
		}
	}
}
