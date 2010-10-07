namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TextPaint : android.graphics.Paint
	{
		internal new static global::java.lang.Class staticClass;
		static TextPaint()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.TextPaint), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.TextPaint(@__env);
			}
		}
		protected TextPaint(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _set7598;
		public virtual void set(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.TextPaint._set7598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.TextPaint.staticClass, global::android.text.TextPaint._set7598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextPaint7599;
		public TextPaint()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint7599, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextPaint7600;
		public TextPaint(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint7600, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextPaint7601;
		public TextPaint(android.graphics.Paint arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.TextPaint.staticClass, global::android.text.TextPaint._TextPaint7601, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _bgColor7602;
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
		internal static global::net.sf.jni4net.jni.FieldId _baselineShift7603;
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
		internal static global::net.sf.jni4net.jni.FieldId _linkColor7604;
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
		internal static global::net.sf.jni4net.jni.FieldId _drawableState7605;
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
		internal static global::net.sf.jni4net.jni.FieldId _density7606;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.TextPaint.staticClass = @__class;
			global::android.text.TextPaint._set7598 = @__env.GetMethodID(global::android.text.TextPaint.staticClass, "set", "(Landroid/text/TextPaint;)V");
			global::android.text.TextPaint._TextPaint7599 = @__env.GetMethodID(global::android.text.TextPaint.staticClass, "<init>", "()V");
			global::android.text.TextPaint._TextPaint7600 = @__env.GetMethodID(global::android.text.TextPaint.staticClass, "<init>", "(I)V");
			global::android.text.TextPaint._TextPaint7601 = @__env.GetMethodID(global::android.text.TextPaint.staticClass, "<init>", "(Landroid/graphics/Paint;)V");
		}
	}
}
