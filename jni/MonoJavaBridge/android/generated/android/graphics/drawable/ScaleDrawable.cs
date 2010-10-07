namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ScaleDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::java.lang.Class staticClass;
		static ScaleDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.ScaleDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.ScaleDrawable(@__env);
			}
		}
		protected ScaleDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate3965;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ScaleDrawable._inflate3965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._inflate3965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable3966;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.ScaleDrawable._getDrawable3966));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getDrawable3966));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3967;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ScaleDrawable._draw3967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._draw3967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3968;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ScaleDrawable._getChangingConfigurations3968);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getChangingConfigurations3968);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3969;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ScaleDrawable._setAlpha3969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._setAlpha3969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3970;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ScaleDrawable._setColorFilter3970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._setColorFilter3970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3971;
		public override bool isStateful() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ScaleDrawable._isStateful3971);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._isStateful3971);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3972;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ScaleDrawable._setVisible3972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._setVisible3972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3973;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ScaleDrawable._getOpacity3973);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getOpacity3973);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3974;
		protected override bool onStateChange(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ScaleDrawable._onStateChange3974, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._onStateChange3974, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3975;
		protected override bool onLevelChange(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ScaleDrawable._onLevelChange3975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._onLevelChange3975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3976;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ScaleDrawable._onBoundsChange3976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._onBoundsChange3976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3977;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ScaleDrawable._getIntrinsicWidth3977);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getIntrinsicWidth3977);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3978;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ScaleDrawable._getIntrinsicHeight3978);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getIntrinsicHeight3978);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3979;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ScaleDrawable._getPadding3979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getPadding3979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3980;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.ScaleDrawable._mutate3980));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._mutate3980));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3981;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.ScaleDrawable._getConstantState3981));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getConstantState3981));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3982;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ScaleDrawable._invalidateDrawable3982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._invalidateDrawable3982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3983;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ScaleDrawable._scheduleDrawable3983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._scheduleDrawable3983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3984;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ScaleDrawable._unscheduleDrawable3984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._unscheduleDrawable3984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ScaleDrawable3985;
		public ScaleDrawable(android.graphics.drawable.Drawable arg0, int arg1, float arg2, float arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._ScaleDrawable3985, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.ScaleDrawable.staticClass = @__class;
			global::android.graphics.drawable.ScaleDrawable._inflate3965 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.ScaleDrawable._getDrawable3966 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.ScaleDrawable._draw3967 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.ScaleDrawable._getChangingConfigurations3968 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.ScaleDrawable._setAlpha3969 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.ScaleDrawable._setColorFilter3970 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.ScaleDrawable._isStateful3971 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.ScaleDrawable._setVisible3972 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.ScaleDrawable._getOpacity3973 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.ScaleDrawable._onStateChange3974 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.ScaleDrawable._onLevelChange3975 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.ScaleDrawable._onBoundsChange3976 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.ScaleDrawable._getIntrinsicWidth3977 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.ScaleDrawable._getIntrinsicHeight3978 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.ScaleDrawable._getPadding3979 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.ScaleDrawable._mutate3980 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.ScaleDrawable._getConstantState3981 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.ScaleDrawable._invalidateDrawable3982 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.ScaleDrawable._scheduleDrawable3983 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.ScaleDrawable._unscheduleDrawable3984 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.ScaleDrawable._ScaleDrawable3985 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;IFF)V");
		}
	}
}
