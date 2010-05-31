namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PaintDrawable : android.graphics.drawable.ShapeDrawable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PaintDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.PaintDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _setCornerRadii3722; 
		public virtual void setCornerRadii(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.PaintDrawable._setCornerRadii3722, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._setCornerRadii3722, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCornerRadius3723; 
		public virtual void setCornerRadius(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.PaintDrawable._setCornerRadius3723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._setCornerRadius3723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflateTag3724; 
		protected override bool inflateTag(java.lang.String arg0, android.content.res.Resources arg1, org.xmlpull.v1.XmlPullParser arg2, android.util.AttributeSet arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.PaintDrawable._inflateTag3724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._inflateTag3724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PaintDrawable3725; 
		public PaintDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._PaintDrawable3725, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PaintDrawable3726; 
		public PaintDrawable(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._PaintDrawable3726, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.PaintDrawable.staticClass = @__class; 
			global::android.graphics.drawable.PaintDrawable._setCornerRadii3722 = @__env.GetMethodID(global::android.graphics.drawable.PaintDrawable.staticClass, "setCornerRadii", "([F)V"); 
			global::android.graphics.drawable.PaintDrawable._setCornerRadius3723 = @__env.GetMethodID(global::android.graphics.drawable.PaintDrawable.staticClass, "setCornerRadius", "(F)V"); 
			global::android.graphics.drawable.PaintDrawable._inflateTag3724 = @__env.GetMethodID(global::android.graphics.drawable.PaintDrawable.staticClass, "inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Z"); 
			global::android.graphics.drawable.PaintDrawable._PaintDrawable3725 = @__env.GetMethodID(global::android.graphics.drawable.PaintDrawable.staticClass, "<init>", "()V"); 
			global::android.graphics.drawable.PaintDrawable._PaintDrawable3726 = @__env.GetMethodID(global::android.graphics.drawable.PaintDrawable.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
