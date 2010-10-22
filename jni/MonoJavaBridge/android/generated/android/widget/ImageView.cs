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
			internal static global::MonoJavaBridge.MethodId _values17148;
			public static global::android.widget.ImageView.ScaleType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.ImageView.ScaleType>(@__env.CallStaticObjectMethod(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._values17148)) as android.widget.ImageView.ScaleType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf17149;
			public static global::android.widget.ImageView.ScaleType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.CallStaticObjectMethod(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._valueOf17149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.ImageView.ScaleType;
			}
			internal static global::MonoJavaBridge.FieldId _CENTER17150;
			public static global::android.widget.ImageView.ScaleType CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _CENTER17150)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CENTER_CROP17151;
			public static global::android.widget.ImageView.ScaleType CENTER_CROP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _CENTER_CROP17151)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CENTER_INSIDE17152;
			public static global::android.widget.ImageView.ScaleType CENTER_INSIDE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _CENTER_INSIDE17152)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_CENTER17153;
			public static global::android.widget.ImageView.ScaleType FIT_CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_CENTER17153)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_END17154;
			public static global::android.widget.ImageView.ScaleType FIT_END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_END17154)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_START17155;
			public static global::android.widget.ImageView.ScaleType FIT_START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_START17155)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_XY17156;
			public static global::android.widget.ImageView.ScaleType FIT_XY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_XY17156)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATRIX17157;
			public static global::android.widget.ImageView.ScaleType MATRIX
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _MATRIX17157)) as android.widget.ImageView.ScaleType;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ImageView.ScaleType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageView$ScaleType"));
				global::android.widget.ImageView.ScaleType._values17148 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "values", "()[Landroid/widget/ImageView/ScaleType;");
				global::android.widget.ImageView.ScaleType._valueOf17149 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._CENTER17150 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._CENTER_CROP17151 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER_CROP", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._CENTER_INSIDE17152 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER_INSIDE", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_CENTER17153 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_CENTER", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_END17154 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_END", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_START17155 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_START", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_XY17156 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_XY", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._MATRIX17157 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "MATRIX", "Landroid/widget/ImageView$ScaleType;");
			}
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable17158;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._getDrawable17158)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getDrawable17158)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha17159;
		public virtual void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setAlpha17159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setAlpha17159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter17160;
		public virtual void setColorFilter(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setColorFilter17160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter17160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter17161;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setColorFilter17161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter17161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter17162;
		public virtual void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setColorFilter17162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter17162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearColorFilter17163;
		public virtual void clearColorFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._clearColorFilter17163);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._clearColorFilter17163);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw17164;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._onDraw17164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onDraw17164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable17165;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._invalidateDrawable17165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._invalidateDrawable17165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable17166;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ImageView._verifyDrawable17166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._verifyDrawable17166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged17167;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._drawableStateChanged17167);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._drawableStateChanged17167);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState17168;
		public virtual int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._onCreateDrawableState17168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onCreateDrawableState17168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setSelected17169;
		public override void setSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setSelected17169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setSelected17169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline17170;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ImageView._getBaseline17170);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getBaseline17170);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17171;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._onMeasure17171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onMeasure17171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onSetAlpha17172;
		protected override bool onSetAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ImageView._onSetAlpha17172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onSetAlpha17172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxHeight17173;
		public virtual void setMaxHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setMaxHeight17173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setMaxHeight17173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxWidth17174;
		public virtual void setMaxWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setMaxWidth17174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setMaxWidth17174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFrame17175;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ImageView._setFrame17175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setFrame17175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setAdjustViewBounds17176;
		public virtual void setAdjustViewBounds(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setAdjustViewBounds17176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setAdjustViewBounds17176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageResource17177;
		public virtual void setImageResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageResource17177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageResource17177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageURI17178;
		public virtual void setImageURI(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageURI17178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageURI17178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageDrawable17179;
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageDrawable17179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageDrawable17179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageBitmap17180;
		public virtual void setImageBitmap(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageBitmap17180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageBitmap17180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageState17181;
		public virtual void setImageState(int[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageState17181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageState17181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setImageLevel17182;
		public virtual void setImageLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageLevel17182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageLevel17182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setScaleType17183;
		public virtual void setScaleType(android.widget.ImageView.ScaleType arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setScaleType17183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setScaleType17183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaleType17184;
		public virtual global::android.widget.ImageView.ScaleType getScaleType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._getScaleType17184)) as android.widget.ImageView.ScaleType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getScaleType17184)) as android.widget.ImageView.ScaleType;
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
		internal static global::MonoJavaBridge.MethodId _getImageMatrix17185;
		public virtual global::android.graphics.Matrix getImageMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._getImageMatrix17185)) as android.graphics.Matrix;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getImageMatrix17185)) as android.graphics.Matrix;
		}
		internal static global::MonoJavaBridge.MethodId _setImageMatrix17186;
		public virtual void setImageMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageMatrix17186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageMatrix17186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ImageView17187;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView17187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageView17188;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView17188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageView17189;
		public ImageView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView17189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ImageView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageView"));
			global::android.widget.ImageView._getDrawable17158 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ImageView._setAlpha17159 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setAlpha", "(I)V");
			global::android.widget.ImageView._setColorFilter17160 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(I)V");
			global::android.widget.ImageView._setColorFilter17161 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.widget.ImageView._setColorFilter17162 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.widget.ImageView._clearColorFilter17163 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "clearColorFilter", "()V");
			global::android.widget.ImageView._onDraw17164 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ImageView._invalidateDrawable17165 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ImageView._verifyDrawable17166 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.ImageView._drawableStateChanged17167 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.ImageView._onCreateDrawableState17168 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.ImageView._setSelected17169 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setSelected", "(Z)V");
			global::android.widget.ImageView._getBaseline17170 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getBaseline", "()I");
			global::android.widget.ImageView._onMeasure17171 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ImageView._onSetAlpha17172 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onSetAlpha", "(I)Z");
			global::android.widget.ImageView._setMaxHeight17173 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setMaxHeight", "(I)V");
			global::android.widget.ImageView._setMaxWidth17174 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setMaxWidth", "(I)V");
			global::android.widget.ImageView._setFrame17175 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.ImageView._setAdjustViewBounds17176 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setAdjustViewBounds", "(Z)V");
			global::android.widget.ImageView._setImageResource17177 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageResource", "(I)V");
			global::android.widget.ImageView._setImageURI17178 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageURI", "(Landroid/net/Uri;)V");
			global::android.widget.ImageView._setImageDrawable17179 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ImageView._setImageBitmap17180 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageBitmap", "(Landroid/graphics/Bitmap;)V");
			global::android.widget.ImageView._setImageState17181 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageState", "([IZ)V");
			global::android.widget.ImageView._setImageLevel17182 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageLevel", "(I)V");
			global::android.widget.ImageView._setScaleType17183 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setScaleType", "(Landroid/widget/ImageView$ScaleType;)V");
			global::android.widget.ImageView._getScaleType17184 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getScaleType", "()Landroid/widget/ImageView$ScaleType;");
			global::android.widget.ImageView._getImageMatrix17185 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getImageMatrix", "()Landroid/graphics/Matrix;");
			global::android.widget.ImageView._setImageMatrix17186 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.widget.ImageView._ImageView17187 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ImageView._ImageView17188 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ImageView._ImageView17189 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
