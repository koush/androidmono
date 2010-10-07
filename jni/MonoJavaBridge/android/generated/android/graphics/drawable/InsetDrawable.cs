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
		internal static global::net.sf.jni4net.jni.MethodId _inflate3851;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._inflate3851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._inflate3851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3852;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._draw3852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._draw3852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3853;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable._getChangingConfigurations3853);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getChangingConfigurations3853);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3854;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._setAlpha3854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setAlpha3854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3855;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._setColorFilter3855, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setColorFilter3855, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3856;
		public override bool isStateful() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable._isStateful3856);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._isStateful3856);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3857;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable._setVisible3857, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setVisible3857, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3858;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable._getOpacity3858);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getOpacity3858);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3859;
		protected override bool onStateChange(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable._onStateChange3859, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._onStateChange3859, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3860;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._onBoundsChange3860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._onBoundsChange3860, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3861;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth3861);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth3861);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3862;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight3862);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight3862);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3863;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable._getPadding3863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getPadding3863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3864;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.InsetDrawable._mutate3864));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._mutate3864));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3865;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.InsetDrawable._getConstantState3865));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getConstantState3865));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3866;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._invalidateDrawable3866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._invalidateDrawable3866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3867;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._scheduleDrawable3867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._scheduleDrawable3867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3868;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable._unscheduleDrawable3868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._unscheduleDrawable3868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InsetDrawable3869;
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._InsetDrawable3869, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InsetDrawable3870;
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._InsetDrawable3870, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.InsetDrawable.staticClass = @__class;
			global::android.graphics.drawable.InsetDrawable._inflate3851 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.InsetDrawable._draw3852 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.InsetDrawable._getChangingConfigurations3853 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.InsetDrawable._setAlpha3854 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.InsetDrawable._setColorFilter3855 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.InsetDrawable._isStateful3856 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.InsetDrawable._setVisible3857 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.InsetDrawable._getOpacity3858 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.InsetDrawable._onStateChange3859 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.InsetDrawable._onBoundsChange3860 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth3861 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight3862 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.InsetDrawable._getPadding3863 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.InsetDrawable._mutate3864 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.InsetDrawable._getConstantState3865 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.InsetDrawable._invalidateDrawable3866 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.InsetDrawable._scheduleDrawable3867 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.InsetDrawable._unscheduleDrawable3868 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.InsetDrawable._InsetDrawable3869 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;IIII)V");
			global::android.graphics.drawable.InsetDrawable._InsetDrawable3870 = @__env.GetMethodID(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V");
		}
	}
}
