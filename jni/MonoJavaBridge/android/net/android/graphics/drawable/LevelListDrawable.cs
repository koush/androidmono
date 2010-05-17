namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LevelListDrawable : android.graphics.drawable.DrawableContainer
	{ 
		internal new static global::java.lang.Class staticClass; 
		static LevelListDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.LevelListDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.LevelListDrawable(@__env); 
			} 
		} 
		protected LevelListDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3487; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LevelListDrawable)) 
				@__env.CallVoidMethod(this, _inflate3487, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LevelListDrawable.staticClass, _inflate3487, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3488; 
		protected override bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LevelListDrawable)) 
				return @__env.CallBooleanMethod(this, _onLevelChange3488, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.LevelListDrawable.staticClass, _onLevelChange3488, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3489; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LevelListDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3489)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.LevelListDrawable.staticClass, _mutate3489)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLevel3490; 
		public virtual void addLevel(int arg0, int arg1, android.graphics.drawable.Drawable arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LevelListDrawable)) 
				@__env.CallVoidMethod(this, _addLevel3490, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LevelListDrawable.staticClass, _addLevel3490, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LevelListDrawable3491; 
		public LevelListDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.LevelListDrawable.staticClass, _LevelListDrawable3491, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.LevelListDrawable.staticClass = @__class; 
			global::android.graphics.drawable.LevelListDrawable._inflate3487 = @__env.GetMethodID(global::android.graphics.drawable.LevelListDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.LevelListDrawable._onLevelChange3488 = @__env.GetMethodID(global::android.graphics.drawable.LevelListDrawable.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.LevelListDrawable._mutate3489 = @__env.GetMethodID(global::android.graphics.drawable.LevelListDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.LevelListDrawable._addLevel3490 = @__env.GetMethodID(global::android.graphics.drawable.LevelListDrawable.staticClass, "addLevel", "(IILandroid/graphics/drawable/Drawable;)V"); 
			global::android.graphics.drawable.LevelListDrawable._LevelListDrawable3491 = @__env.GetMethodID(global::android.graphics.drawable.LevelListDrawable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
