namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TableLayout : android.widget.LinearLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TableLayout()
		{
			InitJNI();
		}
		protected TableLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes12608;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout.LayoutParams._setBaseAttributes12608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._setBaseAttributes12608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12609;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams12609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12610;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams12610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12611;
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams12611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12612;
			public LayoutParams()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams12612);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12613;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams12613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12614;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams12614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TableLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableLayout$LayoutParams"));
				global::android.widget.TableLayout.LayoutParams._setBaseAttributes12608 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams12609 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams12610 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams12611 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams12612 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "()V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams12613 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams12614 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _addView12615;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._addView12615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView12615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView12616;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._addView12616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView12616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView12617;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._addView12617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView12617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView12618;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._addView12618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView12618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout12619;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._onLayout12619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._onLayout12619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout12620;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._requestLayout12620);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._requestLayout12620);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12621;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._onMeasure12621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._onMeasure12621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams12622;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._checkLayoutParams12622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._checkLayoutParams12622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnHierarchyChangeListener12623;
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setOnHierarchyChangeListener12623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setOnHierarchyChangeListener12623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams12624;
		public virtual global::android.widget.TableLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableLayout._generateLayoutParams12624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TableLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._generateLayoutParams12624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TableLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams12625;
		protected override global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableLayout._generateLayoutParams12625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._generateLayoutParams12625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams12626;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableLayout._generateDefaultLayoutParams12626)) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._generateDefaultLayoutParams12626)) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _isShrinkAllColumns12627;
		public virtual bool isShrinkAllColumns() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._isShrinkAllColumns12627);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isShrinkAllColumns12627);
		}
		internal static global::MonoJavaBridge.MethodId _setShrinkAllColumns12628;
		public virtual void setShrinkAllColumns(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setShrinkAllColumns12628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setShrinkAllColumns12628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStretchAllColumns12629;
		public virtual bool isStretchAllColumns() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._isStretchAllColumns12629);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isStretchAllColumns12629);
		}
		internal static global::MonoJavaBridge.MethodId _setStretchAllColumns12630;
		public virtual void setStretchAllColumns(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setStretchAllColumns12630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setStretchAllColumns12630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnCollapsed12631;
		public virtual void setColumnCollapsed(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setColumnCollapsed12631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setColumnCollapsed12631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isColumnCollapsed12632;
		public virtual bool isColumnCollapsed(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._isColumnCollapsed12632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isColumnCollapsed12632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnStretchable12633;
		public virtual void setColumnStretchable(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setColumnStretchable12633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setColumnStretchable12633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isColumnStretchable12634;
		public virtual bool isColumnStretchable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._isColumnStretchable12634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isColumnStretchable12634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnShrinkable12635;
		public virtual void setColumnShrinkable(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setColumnShrinkable12635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setColumnShrinkable12635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isColumnShrinkable12636;
		public virtual bool isColumnShrinkable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._isColumnShrinkable12636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isColumnShrinkable12636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TableLayout12637;
		public TableLayout(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.staticClass, global::android.widget.TableLayout._TableLayout12637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TableLayout12638;
		public TableLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.staticClass, global::android.widget.TableLayout._TableLayout12638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TableLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableLayout"));
			global::android.widget.TableLayout._addView12615 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.TableLayout._addView12616 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.TableLayout._addView12617 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.TableLayout._addView12618 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.TableLayout._onLayout12619 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.TableLayout._requestLayout12620 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "requestLayout", "()V");
			global::android.widget.TableLayout._onMeasure12621 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.TableLayout._checkLayoutParams12622 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.TableLayout._setOnHierarchyChangeListener12623 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.widget.TableLayout._generateLayoutParams12624 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableLayout$LayoutParams;");
			global::android.widget.TableLayout._generateLayoutParams12625 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.TableLayout._generateDefaultLayoutParams12626 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.TableLayout._isShrinkAllColumns12627 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "isShrinkAllColumns", "()Z");
			global::android.widget.TableLayout._setShrinkAllColumns12628 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setShrinkAllColumns", "(Z)V");
			global::android.widget.TableLayout._isStretchAllColumns12629 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "isStretchAllColumns", "()Z");
			global::android.widget.TableLayout._setStretchAllColumns12630 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setStretchAllColumns", "(Z)V");
			global::android.widget.TableLayout._setColumnCollapsed12631 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setColumnCollapsed", "(IZ)V");
			global::android.widget.TableLayout._isColumnCollapsed12632 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "isColumnCollapsed", "(I)Z");
			global::android.widget.TableLayout._setColumnStretchable12633 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setColumnStretchable", "(IZ)V");
			global::android.widget.TableLayout._isColumnStretchable12634 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "isColumnStretchable", "(I)Z");
			global::android.widget.TableLayout._setColumnShrinkable12635 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setColumnShrinkable", "(IZ)V");
			global::android.widget.TableLayout._isColumnShrinkable12636 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "isColumnShrinkable", "(I)Z");
			global::android.widget.TableLayout._TableLayout12637 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TableLayout._TableLayout12638 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
