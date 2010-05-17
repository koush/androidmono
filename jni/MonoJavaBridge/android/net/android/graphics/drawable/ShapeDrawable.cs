namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ShapeDrawable : android.graphics.drawable.Drawable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ShapeDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.ShapeDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.ShapeDrawable(@__env); 
			} 
		} 
		protected ShapeDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public abstract class ShaderFactory : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static ShaderFactory() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.ShapeDrawable.ShaderFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			protected ShaderFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _resize3574; 
			public abstract android.graphics.Shader resize(int arg0, int arg1); 
			internal static global::net.sf.jni4net.jni.MethodId _ShaderFactory3575; 
			public ShaderFactory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, _ShaderFactory3575, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass = @__class; 
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory._resize3574 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, "resize", "(II)Landroid/graphics/Shader;"); 
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory._ShaderFactory3575 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3576; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _inflate3576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _inflate3576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3577; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _draw3577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _draw3577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3578; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3578); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _getChangingConfigurations3578); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3579; 
		public override void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _setDither3579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _setDither3579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3580; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _setAlpha3580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3581; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _setColorFilter3581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3582; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3582); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _getOpacity3582); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3583; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _onBoundsChange3583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3584; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3584); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _getIntrinsicWidth3584); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3585; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3585); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _getIntrinsicHeight3585); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3586; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _getPadding3586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3587; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3587)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ShapeDrawable.staticClass, _mutate3587)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3588; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3588)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ShapeDrawable.staticClass, _getConstantState3588)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw3589; 
		protected virtual void onDraw(android.graphics.drawable.shapes.Shape arg0, android.graphics.Canvas arg1, android.graphics.Paint arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _onDraw3589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _onDraw3589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPadding3590; 
		public virtual void setPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _setPadding3590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _setPadding3590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPadding3591; 
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _setPadding3591, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _setPadding3591, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaint3592; 
		public virtual android.graphics.Paint getPaint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallObjectMethodPtr(this, _getPaint3592)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ShapeDrawable.staticClass, _getPaint3592)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShape3593; 
		public virtual void setShape(android.graphics.drawable.shapes.Shape arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _setShape3593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _setShape3593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflateTag3594; 
		protected virtual bool inflateTag(java.lang.String arg0, android.content.res.Resources arg1, org.xmlpull.v1.XmlPullParser arg2, android.util.AttributeSet arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return @__env.CallBooleanMethod(this, _inflateTag3594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _inflateTag3594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShape3595; 
		public virtual android.graphics.drawable.shapes.Shape getShape() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.Shape>(@__env, @__env.CallObjectMethodPtr(this, _getShape3595)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.Shape>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ShapeDrawable.staticClass, _getShape3595)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShaderFactory3596; 
		public virtual void setShaderFactory(android.graphics.drawable.ShapeDrawable.ShaderFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _setShaderFactory3596, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _setShaderFactory3596, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShaderFactory3597; 
		public virtual android.graphics.drawable.ShapeDrawable.ShaderFactory getShaderFactory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.ShapeDrawable.ShaderFactory>(@__env, @__env.CallObjectMethodPtr(this, _getShaderFactory3597)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.ShapeDrawable.ShaderFactory>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ShapeDrawable.staticClass, _getShaderFactory3597)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntrinsicWidth3598; 
		public virtual void setIntrinsicWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _setIntrinsicWidth3598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _setIntrinsicWidth3598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntrinsicHeight3599; 
		public virtual void setIntrinsicHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ShapeDrawable)) 
				@__env.CallVoidMethod(this, _setIntrinsicHeight3599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ShapeDrawable.staticClass, _setIntrinsicHeight3599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ShapeDrawable3600; 
		public ShapeDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.ShapeDrawable.staticClass, _ShapeDrawable3600, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ShapeDrawable3601; 
		public ShapeDrawable(android.graphics.drawable.shapes.Shape arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.ShapeDrawable.staticClass, _ShapeDrawable3601, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.ShapeDrawable.staticClass = @__class; 
			global::android.graphics.drawable.ShapeDrawable._inflate3576 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.ShapeDrawable._draw3577 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.ShapeDrawable._getChangingConfigurations3578 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.ShapeDrawable._setDither3579 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.drawable.ShapeDrawable._setAlpha3580 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.ShapeDrawable._setColorFilter3581 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.ShapeDrawable._getOpacity3582 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.ShapeDrawable._onBoundsChange3583 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.ShapeDrawable._getIntrinsicWidth3584 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.ShapeDrawable._getIntrinsicHeight3585 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.ShapeDrawable._getPadding3586 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.ShapeDrawable._mutate3587 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.ShapeDrawable._getConstantState3588 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.ShapeDrawable._onDraw3589 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "onDraw", "(Landroid/graphics/drawable/shapes/Shape;Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"); 
			global::android.graphics.drawable.ShapeDrawable._setPadding3590 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setPadding", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.ShapeDrawable._setPadding3591 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setPadding", "(IIII)V"); 
			global::android.graphics.drawable.ShapeDrawable._getPaint3592 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;"); 
			global::android.graphics.drawable.ShapeDrawable._setShape3593 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setShape", "(Landroid/graphics/drawable/shapes/Shape;)V"); 
			global::android.graphics.drawable.ShapeDrawable._inflateTag3594 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Z"); 
			global::android.graphics.drawable.ShapeDrawable._getShape3595 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getShape", "()Landroid/graphics/drawable/shapes/Shape;"); 
			global::android.graphics.drawable.ShapeDrawable._setShaderFactory3596 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setShaderFactory", "(Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;)V"); 
			global::android.graphics.drawable.ShapeDrawable._getShaderFactory3597 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getShaderFactory", "()Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;"); 
			global::android.graphics.drawable.ShapeDrawable._setIntrinsicWidth3598 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setIntrinsicWidth", "(I)V"); 
			global::android.graphics.drawable.ShapeDrawable._setIntrinsicHeight3599 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setIntrinsicHeight", "(I)V"); 
			global::android.graphics.drawable.ShapeDrawable._ShapeDrawable3600 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "<init>", "()V"); 
			global::android.graphics.drawable.ShapeDrawable._ShapeDrawable3601 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/shapes/Shape;)V"); 
		} 
	} 
} 
