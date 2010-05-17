namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ColorDrawable : android.graphics.drawable.Drawable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ColorDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.ColorDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.ColorDrawable(@__env); 
			} 
		} 
		protected ColorDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3300; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				@__env.CallVoidMethod(this, _inflate3300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _inflate3300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3301; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				@__env.CallVoidMethod(this, _draw3301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _draw3301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3302; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3302); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _getChangingConfigurations3302); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3303; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3303, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _setAlpha3303, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3304; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _setColorFilter3304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3305; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3305); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _getOpacity3305); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3306; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3306)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ColorDrawable.staticClass, _getConstantState3306)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlpha3307; 
		public virtual int getAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				return @__env.CallIntMethod(this, _getAlpha3307); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _getAlpha3307); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorDrawable3308; 
		public ColorDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.ColorDrawable.staticClass, _ColorDrawable3308, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorDrawable3309; 
		public ColorDrawable(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.ColorDrawable.staticClass, _ColorDrawable3309, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.ColorDrawable.staticClass = @__class; 
			global::android.graphics.drawable.ColorDrawable._inflate3300 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.ColorDrawable._draw3301 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.ColorDrawable._getChangingConfigurations3302 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.ColorDrawable._setAlpha3303 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.ColorDrawable._setColorFilter3304 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.ColorDrawable._getOpacity3305 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.ColorDrawable._getConstantState3306 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.ColorDrawable._getAlpha3307 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "getAlpha", "()I"); 
			global::android.graphics.drawable.ColorDrawable._ColorDrawable3308 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "<init>", "()V"); 
			global::android.graphics.drawable.ColorDrawable._ColorDrawable3309 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
