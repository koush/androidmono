namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class NinePatchDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::java.lang.Class staticClass;
		static NinePatchDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.NinePatchDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.NinePatchDrawable(@__env);
			}
		}
		protected NinePatchDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate3698;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable._inflate3698, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._inflate3698, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3699;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable._draw3699, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._draw3699, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3700;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable._getChangingConfigurations3700);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._getChangingConfigurations3700);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDither3701;
		public override void setDither(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable._setDither3701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._setDither3701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3702;
		public override void setFilterBitmap(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable._setFilterBitmap3702, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._setFilterBitmap3702, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3703;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable._setAlpha3703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._setAlpha3703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3704;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable._setColorFilter3704, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._setColorFilter3704, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3705;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable._getOpacity3705);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._getOpacity3705);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTransparentRegion3706;
		public override global::android.graphics.Region getTransparentRegion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.NinePatchDrawable._getTransparentRegion3706));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._getTransparentRegion3706));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3707;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable._getIntrinsicWidth3707);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._getIntrinsicWidth3707);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3708;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable._getIntrinsicHeight3708);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._getIntrinsicHeight3708);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumWidth3709;
		public override int getMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable._getMinimumWidth3709);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._getMinimumWidth3709);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumHeight3710;
		public override int getMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable._getMinimumHeight3710);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._getMinimumHeight3710);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3711;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.NinePatchDrawable._getPadding3711, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._getPadding3711, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3712;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.NinePatchDrawable._mutate3712));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._mutate3712));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3713;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.NinePatchDrawable._getConstantState3713));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._getConstantState3713));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPaint3714;
		public virtual global::android.graphics.Paint getPaint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.NinePatchDrawable._getPaint3714));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._getPaint3714));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3715;
		public virtual void setTargetDensity(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3716;
		public virtual void setTargetDensity(android.util.DisplayMetrics arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3716, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3716, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3717;
		public virtual void setTargetDensity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _NinePatchDrawable3718;
		public NinePatchDrawable(android.content.res.Resources arg0, android.graphics.NinePatch arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3718, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _NinePatchDrawable3719;
		public NinePatchDrawable(android.content.res.Resources arg0, android.graphics.Bitmap arg1, byte[] arg2, android.graphics.Rect arg3, java.lang.String arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3719, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _NinePatchDrawable3720;
		public NinePatchDrawable(android.graphics.NinePatch arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3720, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _NinePatchDrawable3721;
		public NinePatchDrawable(android.graphics.Bitmap arg0, byte[] arg1, android.graphics.Rect arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3721, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.NinePatchDrawable.staticClass = @__class;
			global::android.graphics.drawable.NinePatchDrawable._inflate3698 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.NinePatchDrawable._draw3699 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.NinePatchDrawable._getChangingConfigurations3700 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.NinePatchDrawable._setDither3701 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.NinePatchDrawable._setFilterBitmap3702 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.NinePatchDrawable._setAlpha3703 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.NinePatchDrawable._setColorFilter3704 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.NinePatchDrawable._getOpacity3705 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.NinePatchDrawable._getTransparentRegion3706 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;");
			global::android.graphics.drawable.NinePatchDrawable._getIntrinsicWidth3707 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.NinePatchDrawable._getIntrinsicHeight3708 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.NinePatchDrawable._getMinimumWidth3709 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getMinimumWidth", "()I");
			global::android.graphics.drawable.NinePatchDrawable._getMinimumHeight3710 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getMinimumHeight", "()I");
			global::android.graphics.drawable.NinePatchDrawable._getPadding3711 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.NinePatchDrawable._mutate3712 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.NinePatchDrawable._getConstantState3713 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.NinePatchDrawable._getPaint3714 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;");
			global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3715 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3716 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(Landroid/util/DisplayMetrics;)V");
			global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3717 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(I)V");
			global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3718 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/NinePatch;)V");
			global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3719 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V");
			global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3720 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/graphics/NinePatch;)V");
			global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3721 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V");
		}
	}
}
