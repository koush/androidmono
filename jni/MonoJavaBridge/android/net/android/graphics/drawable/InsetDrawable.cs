namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class InsetDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static InsetDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.InsetDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _inflate3645; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._inflate3645, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._inflate3645, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3646; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._draw3646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._draw3646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3647; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable._getChangingConfigurations3647); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getChangingConfigurations3647); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3648; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._setAlpha3648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setAlpha3648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3649; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._setColorFilter3649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setColorFilter3649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3650; 
		public override bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable._isStateful3650); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._isStateful3650); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3651; 
		public override bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable._setVisible3651, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setVisible3651, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3652; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable._getOpacity3652); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getOpacity3652); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3653; 
		protected override bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable._onStateChange3653, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._onStateChange3653, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3654; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._onBoundsChange3654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._onBoundsChange3654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3655; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth3655); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth3655); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3656; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight3656); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight3656); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3657; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable._getPadding3657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getPadding3657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3658; 
		public override global::android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.InsetDrawable._mutate3658)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._mutate3658)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3659; 
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.InsetDrawable._getConstantState3659)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getConstantState3659)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3660; 
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._invalidateDrawable3660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._invalidateDrawable3660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3661; 
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._scheduleDrawable3661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._scheduleDrawable3661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3662; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._unscheduleDrawable3662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._unscheduleDrawable3662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InsetDrawable3663; 
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._InsetDrawable3663, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InsetDrawable3664; 
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._InsetDrawable3664, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.InsetDrawable.staticClass = @__class; 
			global::android.graphics.drawable.InsetDrawable._inflate3645 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.InsetDrawable._draw3646 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.InsetDrawable._getChangingConfigurations3647 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.InsetDrawable._setAlpha3648 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.InsetDrawable._setColorFilter3649 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.InsetDrawable._isStateful3650 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.InsetDrawable._setVisible3651 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.InsetDrawable._getOpacity3652 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.InsetDrawable._onStateChange3653 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.InsetDrawable._onBoundsChange3654 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth3655 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight3656 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.InsetDrawable._getPadding3657 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.InsetDrawable._mutate3658 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.InsetDrawable._getConstantState3659 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.InsetDrawable._invalidateDrawable3660 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.graphics.drawable.InsetDrawable._scheduleDrawable3661 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
			global::android.graphics.drawable.InsetDrawable._unscheduleDrawable3662 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.InsetDrawable._InsetDrawable3663 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;IIII)V"); 
			global::android.graphics.drawable.InsetDrawable._InsetDrawable3664 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V"); 
		} 
	} 
} 
