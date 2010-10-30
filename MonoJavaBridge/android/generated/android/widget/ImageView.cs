namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ImageView : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ImageView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class ScaleType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ScaleType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values17252;
			public static global::android.widget.ImageView.ScaleType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ImageView.ScaleType._values17252.native == global::System.IntPtr.Zero)
					global::android.widget.ImageView.ScaleType._values17252 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "values", "()[Landroid/widget/ImageView/ScaleType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.ImageView.ScaleType>(@__env.CallStaticObjectMethod(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._values17252)) as android.widget.ImageView.ScaleType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf17253;
			public static global::android.widget.ImageView.ScaleType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ImageView.ScaleType._valueOf17253.native == global::System.IntPtr.Zero)
					global::android.widget.ImageView.ScaleType._valueOf17253 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/ImageView$ScaleType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.CallStaticObjectMethod(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._valueOf17253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.ImageView.ScaleType;
			}
			internal static global::MonoJavaBridge.FieldId _CENTER17254;
			public static global::android.widget.ImageView.ScaleType CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _CENTER17254)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CENTER_CROP17255;
			public static global::android.widget.ImageView.ScaleType CENTER_CROP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _CENTER_CROP17255)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CENTER_INSIDE17256;
			public static global::android.widget.ImageView.ScaleType CENTER_INSIDE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _CENTER_INSIDE17256)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_CENTER17257;
			public static global::android.widget.ImageView.ScaleType FIT_CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_CENTER17257)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_END17258;
			public static global::android.widget.ImageView.ScaleType FIT_END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_END17258)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_START17259;
			public static global::android.widget.ImageView.ScaleType FIT_START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_START17259)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_XY17260;
			public static global::android.widget.ImageView.ScaleType FIT_XY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_XY17260)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATRIX17261;
			public static global::android.widget.ImageView.ScaleType MATRIX
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _MATRIX17261)) as android.widget.ImageView.ScaleType;
				}
			}
			static ScaleType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ImageView.ScaleType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageView$ScaleType"));
				global::android.widget.ImageView.ScaleType._CENTER17254 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._CENTER_CROP17255 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER_CROP", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._CENTER_INSIDE17256 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER_INSIDE", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_CENTER17257 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_CENTER", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_END17258 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_END", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_START17259 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_START", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_XY17260 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_XY", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._MATRIX17261 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "MATRIX", "Landroid/widget/ImageView$ScaleType;");
			}
			internal static void InitJNI()
			{
			}
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable17262;
		public virtual global::android.graphics.drawable.Drawable getDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._getDrawable17262.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._getDrawable17262 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getDrawable17262) as android.graphics.drawable.Drawable;
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha17263;
		public virtual void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setAlpha17263.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setAlpha17263 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setAlpha", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setAlpha17263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter17264;
		public virtual void setColorFilter(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setColorFilter17264.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setColorFilter17264 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter17264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter17265;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setColorFilter17265.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setColorFilter17265 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter17265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter17266;
		public virtual void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setColorFilter17266.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setColorFilter17266 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter17266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearColorFilter17267;
		public virtual void clearColorFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._clearColorFilter17267.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._clearColorFilter17267 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "clearColorFilter", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._clearColorFilter17267);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw17268;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._onDraw17268.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._onDraw17268 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onDraw17268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable17269;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._invalidateDrawable17269.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._invalidateDrawable17269 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._invalidateDrawable17269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable17270;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._verifyDrawable17270.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._verifyDrawable17270 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._verifyDrawable17270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged17271;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._drawableStateChanged17271.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._drawableStateChanged17271 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "drawableStateChanged", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._drawableStateChanged17271);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState17272;
		public virtual int[] onCreateDrawableState(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._onCreateDrawableState17272.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._onCreateDrawableState17272 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onCreateDrawableState", "(I)[I");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onCreateDrawableState17272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		public new bool Selected
		{
			set
			{
				setSelected(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelected17273;
		public override void setSelected(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setSelected17273.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setSelected17273 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setSelected", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setSelected17273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline17274;
		public override int getBaseline()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._getBaseline17274.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._getBaseline17274 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getBaseline", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getBaseline17274);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17275;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._onMeasure17275.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._onMeasure17275 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onMeasure", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onMeasure17275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onSetAlpha17276;
		protected override bool onSetAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._onSetAlpha17276.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._onSetAlpha17276 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onSetAlpha", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onSetAlpha17276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxHeight
		{
			set
			{
				setMaxHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxHeight17277;
		public virtual void setMaxHeight(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setMaxHeight17277.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setMaxHeight17277 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setMaxHeight", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setMaxHeight17277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxWidth
		{
			set
			{
				setMaxWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxWidth17278;
		public virtual void setMaxWidth(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setMaxWidth17278.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setMaxWidth17278 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setMaxWidth", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setMaxWidth17278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFrame17279;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setFrame17279.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setFrame17279 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setFrame", "(IIII)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setFrame17279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new bool AdjustViewBounds
		{
			set
			{
				setAdjustViewBounds(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAdjustViewBounds17280;
		public virtual void setAdjustViewBounds(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setAdjustViewBounds17280.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setAdjustViewBounds17280 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setAdjustViewBounds", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setAdjustViewBounds17280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ImageResource
		{
			set
			{
				setImageResource(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setImageResource17281;
		public virtual void setImageResource(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setImageResource17281.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setImageResource17281 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageResource", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageResource17281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.net.Uri ImageURI
		{
			set
			{
				setImageURI(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setImageURI17282;
		public virtual void setImageURI(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setImageURI17282.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setImageURI17282 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageURI", "(Landroid/net/Uri;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageURI17282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable ImageDrawable
		{
			set
			{
				setImageDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setImageDrawable17283;
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setImageDrawable17283.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setImageDrawable17283 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageDrawable17283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Bitmap ImageBitmap
		{
			set
			{
				setImageBitmap(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setImageBitmap17284;
		public virtual void setImageBitmap(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setImageBitmap17284.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setImageBitmap17284 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageBitmap", "(Landroid/graphics/Bitmap;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageBitmap17284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageState17285;
		public virtual void setImageState(int[] arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setImageState17285.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setImageState17285 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageState", "([IZ)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageState17285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int ImageLevel
		{
			set
			{
				setImageLevel(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setImageLevel17286;
		public virtual void setImageLevel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setImageLevel17286.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setImageLevel17286 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageLevel", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageLevel17286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setScaleType17287;
		public virtual void setScaleType(android.widget.ImageView.ScaleType arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setScaleType17287.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setScaleType17287 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setScaleType", "(Landroid/widget/ImageView$ScaleType;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setScaleType17287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaleType17288;
		public virtual global::android.widget.ImageView.ScaleType getScaleType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._getScaleType17288.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._getScaleType17288 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getScaleType", "()Landroid/widget/ImageView$ScaleType;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.widget.ImageView.ScaleType>(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getScaleType17288) as android.widget.ImageView.ScaleType;
		}
		public new global::android.graphics.Matrix ImageMatrix
		{
			get
			{
				return getImageMatrix();
			}
			set
			{
				setImageMatrix(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImageMatrix17289;
		public virtual global::android.graphics.Matrix getImageMatrix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._getImageMatrix17289.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._getImageMatrix17289 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getImageMatrix", "()Landroid/graphics/Matrix;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getImageMatrix17289) as android.graphics.Matrix;
		}
		internal static global::MonoJavaBridge.MethodId _setImageMatrix17290;
		public virtual void setImageMatrix(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._setImageMatrix17290.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._setImageMatrix17290 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageMatrix", "(Landroid/graphics/Matrix;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageMatrix17290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ImageView17291;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._ImageView17291.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._ImageView17291 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView17291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageView17292;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._ImageView17292.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._ImageView17292 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView17292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageView17293;
		public ImageView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._ImageView17293.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._ImageView17293 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView17293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ImageView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ImageView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
