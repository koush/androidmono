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
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.widget.ImageView.ScaleType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ImageView.ScaleType._m0.native == global::System.IntPtr.Zero)
					global::android.widget.ImageView.ScaleType._m0 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "values", "()[Landroid/widget/ImageView/ScaleType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.ImageView.ScaleType>(@__env.CallStaticObjectMethod(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._m0)) as android.widget.ImageView.ScaleType[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.widget.ImageView.ScaleType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ImageView.ScaleType._m1.native == global::System.IntPtr.Zero)
					global::android.widget.ImageView.ScaleType._m1 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/ImageView$ScaleType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.CallStaticObjectMethod(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.ImageView.ScaleType;
			}
			internal static global::MonoJavaBridge.FieldId _CENTER6063;
			public static global::android.widget.ImageView.ScaleType CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _CENTER6063)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CENTER_CROP6064;
			public static global::android.widget.ImageView.ScaleType CENTER_CROP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _CENTER_CROP6064)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CENTER_INSIDE6065;
			public static global::android.widget.ImageView.ScaleType CENTER_INSIDE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _CENTER_INSIDE6065)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_CENTER6066;
			public static global::android.widget.ImageView.ScaleType FIT_CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_CENTER6066)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_END6067;
			public static global::android.widget.ImageView.ScaleType FIT_END
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_END6067)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_START6068;
			public static global::android.widget.ImageView.ScaleType FIT_START
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_START6068)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_XY6069;
			public static global::android.widget.ImageView.ScaleType FIT_XY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _FIT_XY6069)) as android.widget.ImageView.ScaleType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATRIX6070;
			public static global::android.widget.ImageView.ScaleType MATRIX
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.ImageView.ScaleType>(@__env.GetStaticObjectField(global::android.widget.ImageView.ScaleType.staticClass, _MATRIX6070)) as android.widget.ImageView.ScaleType;
				}
			}
			static ScaleType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ImageView.ScaleType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageView$ScaleType"));
				global::android.widget.ImageView.ScaleType._CENTER6063 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._CENTER_CROP6064 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER_CROP", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._CENTER_INSIDE6065 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "CENTER_INSIDE", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_CENTER6066 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_CENTER", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_END6067 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_END", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_START6068 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_START", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._FIT_XY6069 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "FIT_XY", "Landroid/widget/ImageView$ScaleType;");
				global::android.widget.ImageView.ScaleType._MATRIX6070 = @__env.GetStaticFieldIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "MATRIX", "Landroid/widget/ImageView$ScaleType;");
			}
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.graphics.drawable.Drawable getDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ImageView.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.ImageView._m0) as android.graphics.drawable.Drawable;
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setAlpha", "(I)V", ref global::android.widget.ImageView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setColorFilter(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setColorFilter", "(I)V", ref global::android.widget.ImageView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V", ref global::android.widget.ImageView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.widget.ImageView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void clearColorFilter()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "clearColorFilter", "()V", ref global::android.widget.ImageView._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.ImageView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ImageView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ImageView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.widget.ImageView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "drawableStateChanged", "()V", ref global::android.widget.ImageView._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int[] onCreateDrawableState(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.widget.ImageView.staticClass, "onCreateDrawableState", "(I)[I", ref global::android.widget.ImageView._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		public new bool Selected
		{
			set
			{
				setSelected(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override void setSelected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setSelected", "(Z)V", ref global::android.widget.ImageView._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override int getBaseline()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ImageView.staticClass, "getBaseline", "()I", ref global::android.widget.ImageView._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "onMeasure", "(II)V", ref global::android.widget.ImageView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected override bool onSetAlpha(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ImageView.staticClass, "onSetAlpha", "(I)Z", ref global::android.widget.ImageView._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxHeight
		{
			set
			{
				setMaxHeight(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setMaxHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setMaxHeight", "(I)V", ref global::android.widget.ImageView._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxWidth
		{
			set
			{
				setMaxWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setMaxWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setMaxWidth", "(I)V", ref global::android.widget.ImageView._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ImageView.staticClass, "setFrame", "(IIII)Z", ref global::android.widget.ImageView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new bool AdjustViewBounds
		{
			set
			{
				setAdjustViewBounds(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setAdjustViewBounds(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setAdjustViewBounds", "(Z)V", ref global::android.widget.ImageView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ImageResource
		{
			set
			{
				setImageResource(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setImageResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setImageResource", "(I)V", ref global::android.widget.ImageView._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.net.Uri ImageURI
		{
			set
			{
				setImageURI(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setImageURI(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setImageURI", "(Landroid/net/Uri;)V", ref global::android.widget.ImageView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable ImageDrawable
		{
			set
			{
				setImageDrawable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ImageView._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Bitmap ImageBitmap
		{
			set
			{
				setImageBitmap(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setImageBitmap(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setImageBitmap", "(Landroid/graphics/Bitmap;)V", ref global::android.widget.ImageView._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setImageState(int[] arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setImageState", "([IZ)V", ref global::android.widget.ImageView._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int ImageLevel
		{
			set
			{
				setImageLevel(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setImageLevel(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setImageLevel", "(I)V", ref global::android.widget.ImageView._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setScaleType(android.widget.ImageView.ScaleType arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setScaleType", "(Landroid/widget/ImageView$ScaleType;)V", ref global::android.widget.ImageView._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::android.widget.ImageView.ScaleType getScaleType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.widget.ImageView.ScaleType>(this, global::android.widget.ImageView.staticClass, "getScaleType", "()Landroid/widget/ImageView$ScaleType;", ref global::android.widget.ImageView._m26) as android.widget.ImageView.ScaleType;
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
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::android.graphics.Matrix getImageMatrix()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ImageView.staticClass, "getImageMatrix", "()Landroid/graphics/Matrix;", ref global::android.widget.ImageView._m27) as android.graphics.Matrix;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setImageMatrix(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ImageView.staticClass, "setImageMatrix", "(Landroid/graphics/Matrix;)V", ref global::android.widget.ImageView._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._m29.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._m29 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._m30.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._m30 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public ImageView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ImageView._m31.native == global::System.IntPtr.Zero)
				global::android.widget.ImageView._m31 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ImageView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ImageView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageView"));
		}
	}
}
