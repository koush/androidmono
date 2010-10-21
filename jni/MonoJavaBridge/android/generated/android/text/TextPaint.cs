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
		internal static global::MonoJavaBridge.MethodId _set12972;
		public virtual void set(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.TextPaint._set12972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.TextPaint.staticClass, global::android.text.TextPaint._set12972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TextPaint12973;
		public TextPaint()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint12973);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextPaint12974;
		public TextPaint(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint12974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextPaint12975;
		public TextPaint(android.graphics.Paint arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint12975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _bgColor12976;
		public int bgColor
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _bgColor12976);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _baselineShift12977;
		public int baselineShift
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _baselineShift12977);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _linkColor12978;
		public int linkColor
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _linkColor12978);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _drawableState12979;
		public int[] drawableState
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetObjectField(this.JvmHandle, _drawableState12979)) as int[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _density12980;
		public float density
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _density12980);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.TextPaint.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/TextPaint"));
			global::android.text.TextPaint._set12972 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "set", "(Landroid/text/TextPaint;)V");
			global::android.text.TextPaint._TextPaint12973 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "()V");
			global::android.text.TextPaint._TextPaint12974 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "(I)V");
			global::android.text.TextPaint._TextPaint12975 = @__env.GetMethodIDNoThrow(global::android.text.TextPaint.staticClass, "<init>", "(Landroid/graphics/Paint;)V");
			global::android.text.TextPaint._bgColor12976 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "bgColor", "I");
			global::android.text.TextPaint._baselineShift12977 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "baselineShift", "I");
			global::android.text.TextPaint._linkColor12978 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "linkColor", "I");
			global::android.text.TextPaint._drawableState12979 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "drawableState", "[I");
			global::android.text.TextPaint._density12980 = @__env.GetFieldIDNoThrow(global::android.text.TextPaint.staticClass, "density", "F");
		}
	}
}
