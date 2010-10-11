namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextPaint : android.graphics.Paint
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TextPaint()
		{
			InitJNI();
		}
		protected TextPaint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _set7890;
		public virtual void set(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextPaint._set7890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextPaint.staticClass, global::android.text.TextPaint._set7890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TextPaint7891;
		public TextPaint()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint7891);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextPaint7892;
		public TextPaint(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint7892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextPaint7893;
		public TextPaint(android.graphics.Paint arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint7893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _bgColor7894;
		public int bgColor
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _baselineShift7895;
		public int baselineShift
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _linkColor7896;
		public int linkColor
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _drawableState7897;
		public int[] drawableState
		{
			get
			{
				return default(int[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _density7898;
		public float density
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.TextPaint.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextPaint"));
			global::android.text.TextPaint._set7890 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "set", "(Landroid/text/TextPaint;)V");
			global::android.text.TextPaint._TextPaint7891 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "()V");
			global::android.text.TextPaint._TextPaint7892 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "(I)V");
			global::android.text.TextPaint._TextPaint7893 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "(Landroid/graphics/Paint;)V");
		}
	}
}
