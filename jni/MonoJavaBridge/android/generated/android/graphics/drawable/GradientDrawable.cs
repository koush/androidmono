namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GradientDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GradientDrawable()
		{
			InitJNI();
		}
		protected GradientDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Orientation : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Orientation()
			{
				InitJNI();
			}
			internal Orientation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values4013;
			public static global::android.graphics.drawable.GradientDrawable.Orientation[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.GradientDrawable.Orientation>(@__env.CallStaticObjectMethod(android.graphics.drawable.GradientDrawable.Orientation.staticClass, global::android.graphics.drawable.GradientDrawable.Orientation._values4013)) as android.graphics.drawable.GradientDrawable.Orientation[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf4014;
			public static global::android.graphics.drawable.GradientDrawable.Orientation valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.GradientDrawable.Orientation.staticClass, global::android.graphics.drawable.GradientDrawable.Orientation._valueOf4014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.GradientDrawable.Orientation;
			}
			internal static global::MonoJavaBridge.FieldId _BL_TR4015;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BL_TR
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOTTOM_TOP4016;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BOTTOM_TOP
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BR_TL4017;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BR_TL
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LEFT_RIGHT4018;
			public static global::android.graphics.drawable.GradientDrawable.Orientation LEFT_RIGHT
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RIGHT_LEFT4019;
			public static global::android.graphics.drawable.GradientDrawable.Orientation RIGHT_LEFT
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TL_BR4020;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TL_BR
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TOP_BOTTOM4021;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TOP_BOTTOM
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TR_BL4022;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TR_BL
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.GradientDrawable.Orientation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/GradientDrawable$Orientation"));
				global::android.graphics.drawable.GradientDrawable.Orientation._values4013 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "values", "()[Landroid/graphics/drawable/GradientDrawable/Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._valueOf4014 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/drawable/GradientDrawable$Orientation;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSize4023;
		public virtual void setSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setSize4023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setSize4023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _inflate4024;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._inflate4024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._inflate4024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw4025;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._draw4025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._draw4025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations4026;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getChangingConfigurations4026);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getChangingConfigurations4026);
		}
		internal static global::MonoJavaBridge.MethodId _setDither4027;
		public override void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setDither4027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setDither4027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha4028;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setAlpha4028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setAlpha4028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter4029;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setColorFilter4029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setColorFilter4029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity4030;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getOpacity4030);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getOpacity4030);
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange4031;
		protected override bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._onLevelChange4031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._onLevelChange4031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange4032;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._onBoundsChange4032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._onBoundsChange4032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth4033;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth4033);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth4033);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight4034;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight4034);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight4034);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding4035;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getPadding4035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getPadding4035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate4036;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._mutate4036)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._mutate4036)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState4037;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getConstantState4037)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getConstantState4037)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _setColor4038;
		public virtual void setColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setColor4038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setColor4038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCornerRadii4039;
		public virtual void setCornerRadii(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setCornerRadii4039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setCornerRadii4039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCornerRadius4040;
		public virtual void setCornerRadius(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setCornerRadius4040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setCornerRadius4040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStroke4041;
		public virtual void setStroke(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setStroke4041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setStroke4041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStroke4042;
		public virtual void setStroke(int arg0, int arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setStroke4042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setStroke4042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setShape4043;
		public virtual void setShape(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setShape4043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setShape4043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGradientType4044;
		public virtual void setGradientType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setGradientType4044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setGradientType4044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGradientCenter4045;
		public virtual void setGradientCenter(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setGradientCenter4045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setGradientCenter4045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGradientRadius4046;
		public virtual void setGradientRadius(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setGradientRadius4046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setGradientRadius4046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUseLevel4047;
		public virtual void setUseLevel(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setUseLevel4047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setUseLevel4047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _GradientDrawable4048;
		public GradientDrawable(android.graphics.drawable.GradientDrawable.Orientation arg0, int[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._GradientDrawable4048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GradientDrawable4049;
		public GradientDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._GradientDrawable4049);
			Init(@__env, handle);
		}
		public static int RECTANGLE
		{
			get
			{
				return 0;
			}
		}
		public static int OVAL
		{
			get
			{
				return 1;
			}
		}
		public static int LINE
		{
			get
			{
				return 2;
			}
		}
		public static int RING
		{
			get
			{
				return 3;
			}
		}
		public static int LINEAR_GRADIENT
		{
			get
			{
				return 0;
			}
		}
		public static int RADIAL_GRADIENT
		{
			get
			{
				return 1;
			}
		}
		public static int SWEEP_GRADIENT
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.GradientDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/GradientDrawable"));
			global::android.graphics.drawable.GradientDrawable._setSize4023 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setSize", "(II)V");
			global::android.graphics.drawable.GradientDrawable._inflate4024 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.GradientDrawable._draw4025 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.GradientDrawable._getChangingConfigurations4026 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.GradientDrawable._setDither4027 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.GradientDrawable._setAlpha4028 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setColorFilter4029 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.GradientDrawable._getOpacity4030 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.GradientDrawable._onLevelChange4031 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.GradientDrawable._onBoundsChange4032 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth4033 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight4034 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.GradientDrawable._getPadding4035 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.GradientDrawable._mutate4036 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.GradientDrawable._getConstantState4037 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.GradientDrawable._setColor4038 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setColor", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setCornerRadii4039 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadii", "([F)V");
			global::android.graphics.drawable.GradientDrawable._setCornerRadius4040 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadius", "(F)V");
			global::android.graphics.drawable.GradientDrawable._setStroke4041 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(II)V");
			global::android.graphics.drawable.GradientDrawable._setStroke4042 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(IIFF)V");
			global::android.graphics.drawable.GradientDrawable._setShape4043 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setShape", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setGradientType4044 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientType", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setGradientCenter4045 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientCenter", "(FF)V");
			global::android.graphics.drawable.GradientDrawable._setGradientRadius4046 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientRadius", "(F)V");
			global::android.graphics.drawable.GradientDrawable._setUseLevel4047 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setUseLevel", "(Z)V");
			global::android.graphics.drawable.GradientDrawable._GradientDrawable4048 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/GradientDrawable$Orientation;[I)V");
			global::android.graphics.drawable.GradientDrawable._GradientDrawable4049 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "()V");
		}
	}
}
