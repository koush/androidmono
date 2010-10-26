namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ImageView : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ImageView()
		{
			InitJNI();
		}
		protected ImageView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class ScaleType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ScaleType()
			{
				InitJNI();
			}
			internal ScaleType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values17252;
			public static global::android.widget.ImageView.ScaleType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.ImageView.ScaleType>(@__env.CallStaticObjectMethod(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._values17252)) as android.widget.ImageView.ScaleType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf17253;
			public static global::android.widget.ImageView.ScaleType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ImageView.ScaleType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageView$ScaleType"));
				global::android.widget.ImageView.ScaleType._values17252 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "values", "()[Landroid/widget/ImageView/ScaleType;");
				global::android.widget.ImageView.ScaleType._valueOf17253 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._CENTER17254 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._CENTER_CROP17255 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER_CROP", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._CENTER_INSIDE17256 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER_INSIDE", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_CENTER17257 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_CENTER", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_END17258 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_END", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_START17259 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_START", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_XY17260 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_XY", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._MATRIX17261 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "MATRIX", "Landroid/widget/ImageView$ScaleType;");
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
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._getDrawable17262)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getDrawable17262)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha17263;
		public virtual void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setAlpha17263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setAlpha17263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter17264;
		public virtual void setColorFilter(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setColorFilter17264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter17264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter17265;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setColorFilter17265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter17265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter17266;
		public virtual void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setColorFilter17266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter17266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearColorFilter17267;
		public virtual void clearColorFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._clearColorFilter17267);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._clearColorFilter17267);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw17268;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._onDraw17268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onDraw17268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable17269;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._invalidateDrawable17269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._invalidateDrawable17269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable17270;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ImageView._verifyDrawable17270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._verifyDrawable17270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged17271;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._drawableStateChanged17271);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._drawableStateChanged17271);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState17272;
		public virtual int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._onCreateDrawableState17272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onCreateDrawableState17272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setSelected17273;
		public override void setSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setSelected17273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setSelected17273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ImageView._getBaseline17274);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getBaseline17274);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17275;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._onMeasure17275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onMeasure17275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onSetAlpha17276;
		protected override bool onSetAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ImageView._onSetAlpha17276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onSetAlpha17276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxHeight17277;
		public virtual void setMaxHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setMaxHeight17277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setMaxHeight17277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxWidth17278;
		public virtual void setMaxWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setMaxWidth17278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setMaxWidth17278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFrame17279;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ImageView._setFrame17279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setFrame17279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setAdjustViewBounds17280;
		public virtual void setAdjustViewBounds(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setAdjustViewBounds17280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setAdjustViewBounds17280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageResource17281;
		public virtual void setImageResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageResource17281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageResource17281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageURI17282;
		public virtual void setImageURI(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageURI17282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageURI17282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageDrawable17283;
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageDrawable17283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageDrawable17283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageBitmap17284;
		public virtual void setImageBitmap(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageBitmap17284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageBitmap17284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageState17285;
		public virtual void setImageState(int[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageState17285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageState17285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setImageLevel17286;
		public virtual void setImageLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageLevel17286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageLevel17286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setScaleType17287;
		public virtual void setScaleType(android.widget.ImageView.ScaleType arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setScaleType17287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setScaleType17287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaleType17288;
		public virtual global::android.widget.ImageView.ScaleType getScaleType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._getScaleType17288)) as android.widget.ImageView.ScaleType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getScaleType17288)) as android.widget.ImageView.ScaleType;
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
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._getImageMatrix17289)) as android.graphics.Matrix;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getImageMatrix17289)) as android.graphics.Matrix;
		}
		internal static global::MonoJavaBridge.MethodId _setImageMatrix17290;
		public virtual void setImageMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageMatrix17290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageMatrix17290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ImageView17291;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView17291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageView17292;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView17292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageView17293;
		public ImageView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView17293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ImageView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageView"));
			global::android.widget.ImageView._getDrawable17262 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ImageView._setAlpha17263 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setAlpha", "(I)V");
			global::android.widget.ImageView._setColorFilter17264 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(I)V");
			global::android.widget.ImageView._setColorFilter17265 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.widget.ImageView._setColorFilter17266 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.widget.ImageView._clearColorFilter17267 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "clearColorFilter", "()V");
			global::android.widget.ImageView._onDraw17268 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ImageView._invalidateDrawable17269 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ImageView._verifyDrawable17270 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.ImageView._drawableStateChanged17271 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.ImageView._onCreateDrawableState17272 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.ImageView._setSelected17273 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setSelected", "(Z)V");
			global::android.widget.ImageView._getBaseline17274 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getBaseline", "()I");
			global::android.widget.ImageView._onMeasure17275 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ImageView._onSetAlpha17276 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onSetAlpha", "(I)Z");
			global::android.widget.ImageView._setMaxHeight17277 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setMaxHeight", "(I)V");
			global::android.widget.ImageView._setMaxWidth17278 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setMaxWidth", "(I)V");
			global::android.widget.ImageView._setFrame17279 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.ImageView._setAdjustViewBounds17280 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setAdjustViewBounds", "(Z)V");
			global::android.widget.ImageView._setImageResource17281 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageResource", "(I)V");
			global::android.widget.ImageView._setImageURI17282 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageURI", "(Landroid/net/Uri;)V");
			global::android.widget.ImageView._setImageDrawable17283 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ImageView._setImageBitmap17284 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageBitmap", "(Landroid/graphics/Bitmap;)V");
			global::android.widget.ImageView._setImageState17285 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageState", "([IZ)V");
			global::android.widget.ImageView._setImageLevel17286 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageLevel", "(I)V");
			global::android.widget.ImageView._setScaleType17287 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setScaleType", "(Landroid/widget/ImageView$ScaleType;)V");
			global::android.widget.ImageView._getScaleType17288 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getScaleType", "()Landroid/widget/ImageView$ScaleType;");
			global::android.widget.ImageView._getImageMatrix17289 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getImageMatrix", "()Landroid/graphics/Matrix;");
			global::android.widget.ImageView._setImageMatrix17290 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.widget.ImageView._ImageView17291 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ImageView._ImageView17292 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ImageView._ImageView17293 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
