namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class StateListDrawable : android.graphics.drawable.DrawableContainer
	{ 
		internal new static global::java.lang.Class staticClass; 
		static StateListDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.StateListDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.StateListDrawable(@__env); 
			} 
		} 
		protected StateListDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3602; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.StateListDrawable)) 
				@__env.CallVoidMethod(this, _inflate3602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.StateListDrawable.staticClass, _inflate3602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3603; 
		public override bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.StateListDrawable)) 
				return @__env.CallBooleanMethod(this, _isStateful3603); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.StateListDrawable.staticClass, _isStateful3603); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3604; 
		protected override bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.StateListDrawable)) 
				return @__env.CallBooleanMethod(this, _onStateChange3604, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.StateListDrawable.staticClass, _onStateChange3604, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3605; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.StateListDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3605)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.StateListDrawable.staticClass, _mutate3605)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addState3606; 
		public virtual void addState(int[] arg0, android.graphics.drawable.Drawable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.StateListDrawable)) 
				@__env.CallVoidMethod(this, _addState3606, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.StateListDrawable.staticClass, _addState3606, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StateListDrawable3607; 
		public StateListDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.StateListDrawable.staticClass, _StateListDrawable3607, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.StateListDrawable.staticClass = @__class; 
			global::android.graphics.drawable.StateListDrawable._inflate3602 = @__env.GetMethodID(global::android.graphics.drawable.StateListDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.StateListDrawable._isStateful3603 = @__env.GetMethodID(global::android.graphics.drawable.StateListDrawable.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.StateListDrawable._onStateChange3604 = @__env.GetMethodID(global::android.graphics.drawable.StateListDrawable.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.StateListDrawable._mutate3605 = @__env.GetMethodID(global::android.graphics.drawable.StateListDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.StateListDrawable._addState3606 = @__env.GetMethodID(global::android.graphics.drawable.StateListDrawable.staticClass, "addState", "([ILandroid/graphics/drawable/Drawable;)V"); 
			global::android.graphics.drawable.StateListDrawable._StateListDrawable3607 = @__env.GetMethodID(global::android.graphics.drawable.StateListDrawable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
