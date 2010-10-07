namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class LayerDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::java.lang.Class staticClass;
		static LayerDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.LayerDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.LayerDrawable(@__env);
			}
		}
		protected LayerDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getId3871;
		public virtual int getId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.LayerDrawable._getId3871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getId3871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate3872;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._inflate3872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._inflate3872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable3873;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.LayerDrawable._getDrawable3873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getDrawable3873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3874;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._draw3874, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._draw3874, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3875;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.LayerDrawable._getChangingConfigurations3875);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getChangingConfigurations3875);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDither3876;
		public override void setDither(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._setDither3876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setDither3876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3877;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._setAlpha3877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setAlpha3877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3878;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._setColorFilter3878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setColorFilter3878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3879;
		public override bool isStateful() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.LayerDrawable._isStateful3879);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._isStateful3879);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3880;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.LayerDrawable._setVisible3880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setVisible3880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3881;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.LayerDrawable._getOpacity3881);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getOpacity3881);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3882;
		protected override bool onStateChange(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.LayerDrawable._onStateChange3882, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._onStateChange3882, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3883;
		protected override bool onLevelChange(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.LayerDrawable._onLevelChange3883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._onLevelChange3883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3884;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._onBoundsChange3884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._onBoundsChange3884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3885;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.LayerDrawable._getIntrinsicWidth3885);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getIntrinsicWidth3885);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3886;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.LayerDrawable._getIntrinsicHeight3886);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getIntrinsicHeight3886);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3887;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.LayerDrawable._getPadding3887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getPadding3887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3888;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.LayerDrawable._mutate3888));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._mutate3888));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3889;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.LayerDrawable._getConstantState3889));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getConstantState3889));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3890;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._invalidateDrawable3890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._invalidateDrawable3890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3891;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._scheduleDrawable3891, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._scheduleDrawable3891, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3892;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._unscheduleDrawable3892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._unscheduleDrawable3892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setId3893;
		public virtual void setId(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._setId3893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setId3893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findDrawableByLayerId3894;
		public virtual global::android.graphics.drawable.Drawable findDrawableByLayerId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.LayerDrawable._findDrawableByLayerId3894, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._findDrawableByLayerId3894, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNumberOfLayers3895;
		public virtual int getNumberOfLayers() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.LayerDrawable._getNumberOfLayers3895);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getNumberOfLayers3895);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDrawableByLayerId3896;
		public virtual bool setDrawableByLayerId(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.LayerDrawable._setDrawableByLayerId3896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setDrawableByLayerId3896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayerInset3897;
		public virtual void setLayerInset(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.LayerDrawable._setLayerInset3897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setLayerInset3897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LayerDrawable3898;
		public LayerDrawable(android.graphics.drawable.Drawable[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._LayerDrawable3898, this, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.LayerDrawable.staticClass = @__class;
			global::android.graphics.drawable.LayerDrawable._getId3871 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getId", "(I)I");
			global::android.graphics.drawable.LayerDrawable._inflate3872 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.LayerDrawable._getDrawable3873 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.LayerDrawable._draw3874 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.LayerDrawable._getChangingConfigurations3875 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.LayerDrawable._setDither3876 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.LayerDrawable._setAlpha3877 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.LayerDrawable._setColorFilter3878 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.LayerDrawable._isStateful3879 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.LayerDrawable._setVisible3880 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.LayerDrawable._getOpacity3881 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.LayerDrawable._onStateChange3882 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.LayerDrawable._onLevelChange3883 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.LayerDrawable._onBoundsChange3884 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.LayerDrawable._getIntrinsicWidth3885 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.LayerDrawable._getIntrinsicHeight3886 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.LayerDrawable._getPadding3887 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.LayerDrawable._mutate3888 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.LayerDrawable._getConstantState3889 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.LayerDrawable._invalidateDrawable3890 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.LayerDrawable._scheduleDrawable3891 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.LayerDrawable._unscheduleDrawable3892 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.LayerDrawable._setId3893 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setId", "(II)V");
			global::android.graphics.drawable.LayerDrawable._findDrawableByLayerId3894 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "findDrawableByLayerId", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.LayerDrawable._getNumberOfLayers3895 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getNumberOfLayers", "()I");
			global::android.graphics.drawable.LayerDrawable._setDrawableByLayerId3896 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setDrawableByLayerId", "(ILandroid/graphics/drawable/Drawable;)Z");
			global::android.graphics.drawable.LayerDrawable._setLayerInset3897 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setLayerInset", "(IIIII)V");
			global::android.graphics.drawable.LayerDrawable._LayerDrawable3898 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "<init>", "([Landroid/graphics/drawable/Drawable;)V");
		}
	}
}
