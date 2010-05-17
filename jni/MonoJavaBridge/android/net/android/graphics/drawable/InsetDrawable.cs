namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class InsetDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static InsetDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.InsetDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.InsetDrawable(@__env); 
			} 
		} 
		protected InsetDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3439; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				@__env.CallVoidMethod(this, _inflate3439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _inflate3439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3440; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				@__env.CallVoidMethod(this, _draw3440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _draw3440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3441; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3441); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _getChangingConfigurations3441); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3442; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _setAlpha3442, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3443; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _setColorFilter3443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3444; 
		public override bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				return @__env.CallBooleanMethod(this, _isStateful3444); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _isStateful3444); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3445; 
		public override bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				return @__env.CallBooleanMethod(this, _setVisible3445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _setVisible3445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3446; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3446); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _getOpacity3446); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3447; 
		protected override bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				return @__env.CallBooleanMethod(this, _onStateChange3447, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _onStateChange3447, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3448; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _onBoundsChange3448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3449; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3449); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _getIntrinsicWidth3449); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3450; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3450); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _getIntrinsicHeight3450); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3451; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3451, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _getPadding3451, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3452; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3452)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.InsetDrawable.staticClass, _mutate3452)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3453; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3453)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.InsetDrawable.staticClass, _getConstantState3453)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3454; 
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				@__env.CallVoidMethod(this, _invalidateDrawable3454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _invalidateDrawable3454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3455; 
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				@__env.CallVoidMethod(this, _scheduleDrawable3455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _scheduleDrawable3455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3456; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.InsetDrawable)) 
				@__env.CallVoidMethod(this, _unscheduleDrawable3456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.InsetDrawable.staticClass, _unscheduleDrawable3456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InsetDrawable3457; 
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, _InsetDrawable3457, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InsetDrawable3458; 
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, _InsetDrawable3458, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.InsetDrawable.staticClass = @__class; 
			global::android.graphics.drawable.InsetDrawable._inflate3439 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.InsetDrawable._draw3440 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.InsetDrawable._getChangingConfigurations3441 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.InsetDrawable._setAlpha3442 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.InsetDrawable._setColorFilter3443 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.InsetDrawable._isStateful3444 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.InsetDrawable._setVisible3445 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.InsetDrawable._getOpacity3446 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.InsetDrawable._onStateChange3447 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.InsetDrawable._onBoundsChange3448 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth3449 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight3450 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.InsetDrawable._getPadding3451 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.InsetDrawable._mutate3452 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.InsetDrawable._getConstantState3453 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.InsetDrawable._invalidateDrawable3454 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.graphics.drawable.InsetDrawable._scheduleDrawable3455 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
			global::android.graphics.drawable.InsetDrawable._unscheduleDrawable3456 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.InsetDrawable._InsetDrawable3457 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;IIII)V"); 
			global::android.graphics.drawable.InsetDrawable._InsetDrawable3458 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V"); 
		} 
	} 
} 
