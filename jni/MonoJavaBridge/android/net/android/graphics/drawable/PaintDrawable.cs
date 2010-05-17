namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PaintDrawable : android.graphics.drawable.ShapeDrawable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PaintDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.PaintDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.PaintDrawable(@__env); 
			} 
		} 
		protected PaintDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCornerRadii3516; 
		public virtual void setCornerRadii(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PaintDrawable)) 
				@__env.CallVoidMethod(this, _setCornerRadii3516, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.PaintDrawable.staticClass, _setCornerRadii3516, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCornerRadius3517; 
		public virtual void setCornerRadius(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PaintDrawable)) 
				@__env.CallVoidMethod(this, _setCornerRadius3517, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.PaintDrawable.staticClass, _setCornerRadius3517, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflateTag3518; 
		protected override bool inflateTag(java.lang.String arg0, android.content.res.Resources arg1, org.xmlpull.v1.XmlPullParser arg2, android.util.AttributeSet arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PaintDrawable)) 
				return @__env.CallBooleanMethod(this, _inflateTag3518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.PaintDrawable.staticClass, _inflateTag3518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PaintDrawable3519; 
		public PaintDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.PaintDrawable.staticClass, _PaintDrawable3519, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PaintDrawable3520; 
		public PaintDrawable(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.PaintDrawable.staticClass, _PaintDrawable3520, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.PaintDrawable.staticClass = @__class; 
			global::android.graphics.drawable.PaintDrawable._setCornerRadii3516 = @__env.GetMethodID(global::android.graphics.drawable.PaintDrawable.staticClass, "setCornerRadii", "([F)V"); 
			global::android.graphics.drawable.PaintDrawable._setCornerRadius3517 = @__env.GetMethodID(global::android.graphics.drawable.PaintDrawable.staticClass, "setCornerRadius", "(F)V"); 
			global::android.graphics.drawable.PaintDrawable._inflateTag3518 = @__env.GetMethodID(global::android.graphics.drawable.PaintDrawable.staticClass, "inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Z"); 
			global::android.graphics.drawable.PaintDrawable._PaintDrawable3519 = @__env.GetMethodID(global::android.graphics.drawable.PaintDrawable.staticClass, "<init>", "()V"); 
			global::android.graphics.drawable.PaintDrawable._PaintDrawable3520 = @__env.GetMethodID(global::android.graphics.drawable.PaintDrawable.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
