namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TableRow : android.widget.LinearLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TableRow()
		{
			InitJNI();
		}
		protected TableRow(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.widget.LinearLayout.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutParams()
			{
				InitJNI();
			}
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes12639;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableRow.LayoutParams._setBaseAttributes12639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._setBaseAttributes12639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12640;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams12640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12641;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams12641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12642;
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams12642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12643;
			public LayoutParams()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams12643);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12644;
			public LayoutParams(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams12644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12645;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams12645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12646;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams12646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _column12647;
			public int column
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _span12648;
			public int span
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
				global::android.widget.TableRow.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableRow$LayoutParams"));
				global::android.widget.TableRow.LayoutParams._setBaseAttributes12639 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams12640 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams12641 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams12642 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams12643 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "()V");
				global::android.widget.TableRow.LayoutParams._LayoutParams12644 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(I)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams12645 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams12646 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onLayout12649;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableRow._onLayout12649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._onLayout12649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12650;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableRow._onMeasure12650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._onMeasure12650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams12651;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableRow._checkLayoutParams12651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._checkLayoutParams12651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnHierarchyChangeListener12652;
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableRow._setOnHierarchyChangeListener12652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._setOnHierarchyChangeListener12652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams12653;
		public virtual global::android.widget.TableRow.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableRow._generateLayoutParams12653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TableRow.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._generateLayoutParams12653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TableRow.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams12654;
		protected override global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableRow._generateLayoutParams12654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._generateLayoutParams12654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams12655;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableRow._generateDefaultLayoutParams12655)) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._generateDefaultLayoutParams12655)) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _getVirtualChildAt12656;
		public virtual global::android.view.View getVirtualChildAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableRow._getVirtualChildAt12656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._getVirtualChildAt12656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		public new int VirtualChildCount
		{
			get
			{
				return getVirtualChildCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVirtualChildCount12657;
		public virtual int getVirtualChildCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TableRow._getVirtualChildCount12657);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._getVirtualChildCount12657);
		}
		internal static global::MonoJavaBridge.MethodId _TableRow12658;
		public TableRow(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.staticClass, global::android.widget.TableRow._TableRow12658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TableRow12659;
		public TableRow(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.staticClass, global::android.widget.TableRow._TableRow12659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TableRow.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableRow"));
			global::android.widget.TableRow._onLayout12649 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.TableRow._onMeasure12650 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "onMeasure", "(II)V");
			global::android.widget.TableRow._checkLayoutParams12651 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.TableRow._setOnHierarchyChangeListener12652 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.widget.TableRow._generateLayoutParams12653 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableRow$LayoutParams;");
			global::android.widget.TableRow._generateLayoutParams12654 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.TableRow._generateDefaultLayoutParams12655 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.TableRow._getVirtualChildAt12656 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "getVirtualChildAt", "(I)Landroid/view/View;");
			global::android.widget.TableRow._getVirtualChildCount12657 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "getVirtualChildCount", "()I");
			global::android.widget.TableRow._TableRow12658 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TableRow._TableRow12659 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
