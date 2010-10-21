namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FrameLayout : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FrameLayout()
		{
			InitJNI();
		}
		protected FrameLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutParams()
			{
				InitJNI();
			}
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16987;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams16987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16988;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams16988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16989;
			public LayoutParams(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams16989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16990;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams16990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16991;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams16991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _gravity16992;
			public int gravity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _gravity16992);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.FrameLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FrameLayout$LayoutParams"));
				global::android.widget.FrameLayout.LayoutParams._LayoutParams16987 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.FrameLayout.LayoutParams._LayoutParams16988 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.FrameLayout.LayoutParams._LayoutParams16989 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(III)V");
				global::android.widget.FrameLayout.LayoutParams._LayoutParams16990 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.FrameLayout.LayoutParams._LayoutParams16991 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::android.widget.FrameLayout.LayoutParams._gravity16992 = @__env.GetFieldIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "gravity", "I");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setForeground16993;
		public virtual void setForeground(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._setForeground16993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._setForeground16993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _draw16994;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._draw16994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._draw16994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged16995;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._onSizeChanged16995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._onSizeChanged16995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout16996;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._onLayout16996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._onLayout16996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable16997;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout._verifyDrawable16997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._verifyDrawable16997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged16998;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._drawableStateChanged16998);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._drawableStateChanged16998);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16999;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._onMeasure16999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._onMeasure16999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17000;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout._checkLayoutParams17000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._checkLayoutParams17000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17001;
		public virtual global::android.widget.FrameLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.FrameLayout._generateLayoutParams17001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.FrameLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._generateLayoutParams17001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.FrameLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17002;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.FrameLayout._generateLayoutParams17002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._generateLayoutParams17002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17003;
		protected virtual global::android.widget.FrameLayout.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.FrameLayout._generateDefaultLayoutParams17003)) as android.widget.FrameLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._generateDefaultLayoutParams17003)) as android.widget.FrameLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _gatherTransparentRegion17004;
		public override bool gatherTransparentRegion(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout._gatherTransparentRegion17004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._gatherTransparentRegion17004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setForegroundGravity17005;
		public virtual void setForegroundGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._setForegroundGravity17005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._setForegroundGravity17005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable Foreground
		{
			get
			{
				return getForeground();
			}
			set
			{
				setForeground(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getForeground17006;
		public virtual global::android.graphics.drawable.Drawable getForeground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.FrameLayout._getForeground17006)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._getForeground17006)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setMeasureAllChildren17007;
		public virtual void setMeasureAllChildren(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._setMeasureAllChildren17007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._setMeasureAllChildren17007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ConsiderGoneChildrenWhenMeasuring
		{
			get
			{
				return getConsiderGoneChildrenWhenMeasuring();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConsiderGoneChildrenWhenMeasuring17008;
		public virtual bool getConsiderGoneChildrenWhenMeasuring() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout._getConsiderGoneChildrenWhenMeasuring17008);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._getConsiderGoneChildrenWhenMeasuring17008);
		}
		internal static global::MonoJavaBridge.MethodId _FrameLayout17009;
		public FrameLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._FrameLayout17009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FrameLayout17010;
		public FrameLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._FrameLayout17010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FrameLayout17011;
		public FrameLayout(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._FrameLayout17011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.FrameLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FrameLayout"));
			global::android.widget.FrameLayout._setForeground16993 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "setForeground", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.FrameLayout._draw16994 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.FrameLayout._onSizeChanged16995 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.FrameLayout._onLayout16996 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.FrameLayout._verifyDrawable16997 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.FrameLayout._drawableStateChanged16998 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "drawableStateChanged", "()V");
			global::android.widget.FrameLayout._onMeasure16999 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.FrameLayout._checkLayoutParams17000 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.FrameLayout._generateLayoutParams17001 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;");
			global::android.widget.FrameLayout._generateLayoutParams17002 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.FrameLayout._generateDefaultLayoutParams17003 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/FrameLayout$LayoutParams;");
			global::android.widget.FrameLayout._gatherTransparentRegion17004 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z");
			global::android.widget.FrameLayout._setForegroundGravity17005 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "setForegroundGravity", "(I)V");
			global::android.widget.FrameLayout._getForeground17006 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "getForeground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.FrameLayout._setMeasureAllChildren17007 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "setMeasureAllChildren", "(Z)V");
			global::android.widget.FrameLayout._getConsiderGoneChildrenWhenMeasuring17008 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "getConsiderGoneChildrenWhenMeasuring", "()Z");
			global::android.widget.FrameLayout._FrameLayout17009 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.FrameLayout._FrameLayout17010 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.FrameLayout._FrameLayout17011 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
