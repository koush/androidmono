namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GradientDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GradientDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Orientation : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Orientation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values6019;
			public static global::android.graphics.drawable.GradientDrawable.Orientation[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.GradientDrawable.Orientation>(@__env.CallStaticObjectMethod(android.graphics.drawable.GradientDrawable.Orientation.staticClass, global::android.graphics.drawable.GradientDrawable.Orientation._values6019)) as android.graphics.drawable.GradientDrawable.Orientation[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf6020;
			public static global::android.graphics.drawable.GradientDrawable.Orientation valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.CallStaticObjectMethod(android.graphics.drawable.GradientDrawable.Orientation.staticClass, global::android.graphics.drawable.GradientDrawable.Orientation._valueOf6020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.GradientDrawable.Orientation;
			}
			internal static global::MonoJavaBridge.FieldId _BL_TR6021;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BL_TR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _BL_TR6021)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOTTOM_TOP6022;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BOTTOM_TOP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _BOTTOM_TOP6022)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BR_TL6023;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BR_TL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _BR_TL6023)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LEFT_RIGHT6024;
			public static global::android.graphics.drawable.GradientDrawable.Orientation LEFT_RIGHT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _LEFT_RIGHT6024)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RIGHT_LEFT6025;
			public static global::android.graphics.drawable.GradientDrawable.Orientation RIGHT_LEFT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _RIGHT_LEFT6025)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TL_BR6026;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TL_BR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _TL_BR6026)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TOP_BOTTOM6027;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TOP_BOTTOM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _TOP_BOTTOM6027)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TR_BL6028;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TR_BL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _TR_BL6028)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			static Orientation()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.GradientDrawable.Orientation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/GradientDrawable$Orientation"));
				global::android.graphics.drawable.GradientDrawable.Orientation._values6019 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "values", "()[Landroid/graphics/drawable/GradientDrawable/Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._valueOf6020 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._BL_TR6021 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "BL_TR", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._BOTTOM_TOP6022 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "BOTTOM_TOP", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._BR_TL6023 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "BR_TL", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._LEFT_RIGHT6024 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "LEFT_RIGHT", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._RIGHT_LEFT6025 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "RIGHT_LEFT", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._TL_BR6026 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "TL_BR", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._TOP_BOTTOM6027 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "TOP_BOTTOM", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._TR_BL6028 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "TR_BL", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSize6029;
		public virtual void setSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setSize6029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setSize6029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _inflate6030;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._inflate6030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._inflate6030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw6031;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._draw6031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._draw6031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations6032;
		public override int getChangingConfigurations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getChangingConfigurations6032);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getChangingConfigurations6032);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDither6033;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setDither6033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setDither6033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha6034;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setAlpha6034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setAlpha6034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter6035;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setColorFilter6035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setColorFilter6035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity6036;
		public override int getOpacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getOpacity6036);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getOpacity6036);
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange6037;
		protected override bool onLevelChange(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._onLevelChange6037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._onLevelChange6037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange6038;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._onBoundsChange6038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._onBoundsChange6038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth6039;
		public override int getIntrinsicWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth6039);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth6039);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight6040;
		public override int getIntrinsicHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight6040);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight6040);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding6041;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getPadding6041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getPadding6041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6042;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._mutate6042)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._mutate6042)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState6043;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._getConstantState6043)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getConstantState6043)) as android.graphics.drawable.Drawable.ConstantState;
		}
		public new int Color
		{
			set
			{
				setColor(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setColor6044;
		public virtual void setColor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setColor6044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setColor6044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float[] CornerRadii
		{
			set
			{
				setCornerRadii(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCornerRadii6045;
		public virtual void setCornerRadii(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setCornerRadii6045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setCornerRadii6045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float CornerRadius
		{
			set
			{
				setCornerRadius(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCornerRadius6046;
		public virtual void setCornerRadius(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setCornerRadius6046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setCornerRadius6046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStroke6047;
		public virtual void setStroke(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setStroke6047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setStroke6047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStroke6048;
		public virtual void setStroke(int arg0, int arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setStroke6048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setStroke6048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int Shape
		{
			set
			{
				setShape(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setShape6049;
		public virtual void setShape(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setShape6049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setShape6049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int GradientType
		{
			set
			{
				setGradientType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGradientType6050;
		public virtual void setGradientType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setGradientType6050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setGradientType6050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGradientCenter6051;
		public virtual void setGradientCenter(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setGradientCenter6051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setGradientCenter6051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float GradientRadius
		{
			set
			{
				setGradientRadius(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGradientRadius6052;
		public virtual void setGradientRadius(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setGradientRadius6052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setGradientRadius6052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool UseLevel
		{
			set
			{
				setUseLevel(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setUseLevel6053;
		public virtual void setUseLevel(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable._setUseLevel6053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setUseLevel6053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _GradientDrawable6054;
		public GradientDrawable(android.graphics.drawable.GradientDrawable.Orientation arg0, int[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._GradientDrawable6054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GradientDrawable6055;
		public GradientDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._GradientDrawable6055);
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
		static GradientDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.GradientDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/GradientDrawable"));
			global::android.graphics.drawable.GradientDrawable._setSize6029 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setSize", "(II)V");
			global::android.graphics.drawable.GradientDrawable._inflate6030 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.GradientDrawable._draw6031 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.GradientDrawable._getChangingConfigurations6032 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.GradientDrawable._setDither6033 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.GradientDrawable._setAlpha6034 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setColorFilter6035 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.GradientDrawable._getOpacity6036 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.GradientDrawable._onLevelChange6037 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.GradientDrawable._onBoundsChange6038 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth6039 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight6040 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.GradientDrawable._getPadding6041 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.GradientDrawable._mutate6042 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.GradientDrawable._getConstantState6043 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.GradientDrawable._setColor6044 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setColor", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setCornerRadii6045 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadii", "([F)V");
			global::android.graphics.drawable.GradientDrawable._setCornerRadius6046 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadius", "(F)V");
			global::android.graphics.drawable.GradientDrawable._setStroke6047 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(II)V");
			global::android.graphics.drawable.GradientDrawable._setStroke6048 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(IIFF)V");
			global::android.graphics.drawable.GradientDrawable._setShape6049 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setShape", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setGradientType6050 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientType", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setGradientCenter6051 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientCenter", "(FF)V");
			global::android.graphics.drawable.GradientDrawable._setGradientRadius6052 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientRadius", "(F)V");
			global::android.graphics.drawable.GradientDrawable._setUseLevel6053 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "setUseLevel", "(Z)V");
			global::android.graphics.drawable.GradientDrawable._GradientDrawable6054 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/GradientDrawable$Orientation;[I)V");
			global::android.graphics.drawable.GradientDrawable._GradientDrawable6055 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
