namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextPaint : android.graphics.Paint
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TextPaint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _set13033;
		public virtual void set(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextPaint._set13033.native == global::System.IntPtr.Zero)
				global::android.text.TextPaint._set13033 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "set", "(Landroid/text/TextPaint;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.TextPaint.staticClass, global::android.text.TextPaint._set13033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TextPaint13034;
		public TextPaint() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextPaint._TextPaint13034.native == global::System.IntPtr.Zero)
				global::android.text.TextPaint._TextPaint13034 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint13034);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextPaint13035;
		public TextPaint(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextPaint._TextPaint13035.native == global::System.IntPtr.Zero)
				global::android.text.TextPaint._TextPaint13035 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint13035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextPaint13036;
		public TextPaint(android.graphics.Paint arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.TextPaint._TextPaint13036.native == global::System.IntPtr.Zero)
				global::android.text.TextPaint._TextPaint13036 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "(Landroid/graphics/Paint;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint13036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _bgColor13037;
		public int bgColor
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _bgColor13037);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _baselineShift13038;
		public int baselineShift
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _baselineShift13038);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _linkColor13039;
		public int linkColor
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _linkColor13039);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _drawableState13040;
		public int[] drawableState
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetObjectField(this.JvmHandle, _drawableState13040)) as int[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _density13041;
		public float density
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _density13041);
			}
			set
			{
			}
		}
		static TextPaint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.TextPaint.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextPaint"));
			global::android.text.TextPaint._bgColor13037 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "bgColor", "I");
			global::android.text.TextPaint._baselineShift13038 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "baselineShift", "I");
			global::android.text.TextPaint._linkColor13039 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "linkColor", "I");
			global::android.text.TextPaint._drawableState13040 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "drawableState", "[I");
			global::android.text.TextPaint._density13041 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "density", "F");
		}
		internal static void InitJNI()
		{
		}
	}
}
