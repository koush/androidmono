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
		internal static global::net.sf.jni4net.jni.MethodId _inflate3503; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				@__env.CallVoidMethod(this, _inflate3503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _inflate3503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3504; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				@__env.CallVoidMethod(this, _draw3504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _draw3504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3505; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3505); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _getChangingConfigurations3505); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3506; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _setAlpha3506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3507; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _setColorFilter3507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3508; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3508); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _getOpacity3508); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3509; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3509)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ColorDrawable.staticClass, _getConstantState3509)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlpha3510; 
		public virtual int getAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ColorDrawable)) 
				return @__env.CallIntMethod(this, _getAlpha3510); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ColorDrawable.staticClass, _getAlpha3510); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorDrawable3511; 
		public ColorDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.ColorDrawable.staticClass, _ColorDrawable3511, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorDrawable3512; 
		public ColorDrawable(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.ColorDrawable.staticClass, _ColorDrawable3512, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.ColorDrawable.staticClass = @__class; 
			global::android.graphics.drawable.ColorDrawable._inflate3503 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.ColorDrawable._draw3504 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.ColorDrawable._getChangingConfigurations3505 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.ColorDrawable._setAlpha3506 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.ColorDrawable._setColorFilter3507 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.ColorDrawable._getOpacity3508 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.ColorDrawable._getConstantState3509 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.ColorDrawable._getAlpha3510 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "getAlpha", "()I"); 
			global::android.graphics.drawable.ColorDrawable._ColorDrawable3511 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "<init>", "()V"); 
			global::android.graphics.drawable.ColorDrawable._ColorDrawable3512 = @__env.GetMethodID(global::android.graphics.drawable.ColorDrawable.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
