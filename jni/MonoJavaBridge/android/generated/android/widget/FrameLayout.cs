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
			internal static global::MonoJavaBridge.MethodId _LayoutParams11832;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams11832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11833;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams11833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11834;
			public LayoutParams(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams11834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11835;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams11835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11836;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._LayoutParams11836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _gravity11837;
			public int gravity
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.FrameLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FrameLayout$LayoutParams"));
				global::android.widget.FrameLayout.LayoutParams._LayoutParams11832 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.FrameLayout.LayoutParams._LayoutParams11833 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.FrameLayout.LayoutParams._LayoutParams11834 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(III)V");
				global::android.widget.FrameLayout.LayoutParams._LayoutParams11835 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.FrameLayout.LayoutParams._LayoutParams11836 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setForeground11838;
		public virtual void setForeground(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._setForeground11838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._setForeground11838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _draw11839;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._draw11839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._draw11839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged11840;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._onSizeChanged11840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._onSizeChanged11840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout11841;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._onLayout11841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._onLayout11841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable11842;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout._verifyDrawable11842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._verifyDrawable11842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged11843;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._drawableStateChanged11843);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._drawableStateChanged11843);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure11844;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._onMeasure11844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._onMeasure11844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams11845;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout._checkLayoutParams11845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._checkLayoutParams11845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams11846;
		public virtual global::android.widget.FrameLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.FrameLayout._generateLayoutParams11846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.FrameLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._generateLayoutParams11846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.FrameLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams11847;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.FrameLayout._generateLayoutParams11847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._generateLayoutParams11847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams11848;
		protected virtual global::android.widget.FrameLayout.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.FrameLayout._generateDefaultLayoutParams11848)) as android.widget.FrameLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._generateDefaultLayoutParams11848)) as android.widget.FrameLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _gatherTransparentRegion11849;
		public override bool gatherTransparentRegion(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout._gatherTransparentRegion11849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._gatherTransparentRegion11849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setForegroundGravity11850;
		public virtual void setForegroundGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._setForegroundGravity11850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._setForegroundGravity11850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getForeground11851;
		public virtual global::android.graphics.drawable.Drawable getForeground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.FrameLayout._getForeground11851)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._getForeground11851)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setMeasureAllChildren11852;
		public virtual void setMeasureAllChildren(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.FrameLayout._setMeasureAllChildren11852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._setMeasureAllChildren11852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ConsiderGoneChildrenWhenMeasuring
		{
			get
			{
				return getConsiderGoneChildrenWhenMeasuring();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConsiderGoneChildrenWhenMeasuring11853;
		public virtual bool getConsiderGoneChildrenWhenMeasuring() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout._getConsiderGoneChildrenWhenMeasuring11853);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._getConsiderGoneChildrenWhenMeasuring11853);
		}
		internal static global::MonoJavaBridge.MethodId _FrameLayout11854;
		public FrameLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._FrameLayout11854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FrameLayout11855;
		public FrameLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._FrameLayout11855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FrameLayout11856;
		public FrameLayout(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._FrameLayout11856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.FrameLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FrameLayout"));
			global::android.widget.FrameLayout._setForeground11838 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "setForeground", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.FrameLayout._draw11839 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.FrameLayout._onSizeChanged11840 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.FrameLayout._onLayout11841 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.FrameLayout._verifyDrawable11842 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.FrameLayout._drawableStateChanged11843 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "drawableStateChanged", "()V");
			global::android.widget.FrameLayout._onMeasure11844 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.FrameLayout._checkLayoutParams11845 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.FrameLayout._generateLayoutParams11846 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;");
			global::android.widget.FrameLayout._generateLayoutParams11847 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.FrameLayout._generateDefaultLayoutParams11848 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/FrameLayout$LayoutParams;");
			global::android.widget.FrameLayout._gatherTransparentRegion11849 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z");
			global::android.widget.FrameLayout._setForegroundGravity11850 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "setForegroundGravity", "(I)V");
			global::android.widget.FrameLayout._getForeground11851 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "getForeground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.FrameLayout._setMeasureAllChildren11852 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "setMeasureAllChildren", "(Z)V");
			global::android.widget.FrameLayout._getConsiderGoneChildrenWhenMeasuring11853 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "getConsiderGoneChildrenWhenMeasuring", "()Z");
			global::android.widget.FrameLayout._FrameLayout11854 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.FrameLayout._FrameLayout11855 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.FrameLayout._FrameLayout11856 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
