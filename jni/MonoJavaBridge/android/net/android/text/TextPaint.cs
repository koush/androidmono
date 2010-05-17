namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TextPaint : android.graphics.Paint
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TextPaint() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.TextPaint), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _set6623; 
		public virtual void set(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.TextPaint)) 
				@__env.CallVoidMethod(this, _set6623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.TextPaint.staticClass, _set6623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextPaint6624; 
		public TextPaint()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.TextPaint.staticClass, _TextPaint6624, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextPaint6625; 
		public TextPaint(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.TextPaint.staticClass, _TextPaint6625, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextPaint6626; 
		public TextPaint(android.graphics.Paint arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.TextPaint.staticClass, _TextPaint6626, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _bgColor6627; 
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
		internal static global::net.sf.jni4net.jni.FieldId _baselineShift6628; 
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
		internal static global::net.sf.jni4net.jni.FieldId _linkColor6629; 
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
		internal static global::net.sf.jni4net.jni.FieldId _drawableState6630; 
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
		internal static global::net.sf.jni4net.jni.FieldId _density6631; 
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
			global::android.text.TextPaint._set6623 = @__env.GetMethodID(global::android.text.TextPaint.staticClass, "set", "(Landroid/text/TextPaint;)V"); 
			global::android.text.TextPaint._TextPaint6624 = @__env.GetMethodID(global::android.text.TextPaint.staticClass, "<init>", "()V"); 
			global::android.text.TextPaint._TextPaint6625 = @__env.GetMethodID(global::android.text.TextPaint.staticClass, "<init>", "(I)V"); 
			global::android.text.TextPaint._TextPaint6626 = @__env.GetMethodID(global::android.text.TextPaint.staticClass, "<init>", "(Landroid/graphics/Paint;)V"); 
		} 
	} 
} 
