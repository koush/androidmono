namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.AdapterView_))]
	public abstract partial class AdapterView : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AdapterView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AdapterContextMenuInfo : java.lang.Object, android.view.ContextMenu_ContextMenuInfo
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AdapterContextMenuInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public AdapterContextMenuInfo(android.view.View arg0, int arg1, long arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AdapterView.AdapterContextMenuInfo._m0.native == global::System.IntPtr.Zero)
					global::android.widget.AdapterView.AdapterContextMenuInfo._m0 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;IJ)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.AdapterContextMenuInfo.staticClass, global::android.widget.AdapterView.AdapterContextMenuInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _targetView6035;
			public global::android.view.View targetView
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _targetView6035)) as android.view.View;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _position6036;
			public int position
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _position6036);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _id6037;
			public long id
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _id6037);
				}
				set
				{
				}
			}
			static AdapterContextMenuInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$AdapterContextMenuInfo"));
				global::android.widget.AdapterView.AdapterContextMenuInfo._targetView6035 = @__env.GetFieldIDNoThrow(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "targetView", "Landroid/view/View;");
				global::android.widget.AdapterView.AdapterContextMenuInfo._position6036 = @__env.GetFieldIDNoThrow(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "position", "I");
				global::android.widget.AdapterView.AdapterContextMenuInfo._id6037 = @__env.GetFieldIDNoThrow(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "id", "J");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AdapterView.OnItemClickListener_))]
		public partial interface OnItemClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AdapterView.OnItemClickListener))]
		internal sealed partial class OnItemClickListener_ : java.lang.Object, OnItemClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnItemClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.AdapterView.OnItemClickListener.onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.OnItemClickListener_.staticClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", ref global::android.widget.AdapterView.OnItemClickListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			static OnItemClickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$OnItemClickListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnItemClickListenerDelegate(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);

		internal partial class OnItemClickListenerDelegateWrapper : java.lang.Object, OnItemClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnItemClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnItemClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.OnItemClickListenerDelegateWrapper.staticClass, global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnItemClickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView_OnItemClickListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnItemClickListenerDelegateWrapper
		{
			private OnItemClickListenerDelegate myDelegate;
			public void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3)
			{
				myDelegate(arg0, arg1, arg2, arg3);
			}
			public static implicit operator OnItemClickListenerDelegateWrapper(OnItemClickListenerDelegate d)
			{
				global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper ret = new global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AdapterView.OnItemLongClickListener_))]
		public partial interface OnItemLongClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onItemLongClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AdapterView.OnItemLongClickListener))]
		internal sealed partial class OnItemLongClickListener_ : java.lang.Object, OnItemLongClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnItemLongClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.widget.AdapterView.OnItemLongClickListener.onItemLongClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AdapterView.OnItemLongClickListener_.staticClass, "onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z", ref global::android.widget.AdapterView.OnItemLongClickListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			static OnItemLongClickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemLongClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$OnItemLongClickListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnItemLongClickListenerDelegate(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);

		internal partial class OnItemLongClickListenerDelegateWrapper : java.lang.Object, OnItemLongClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnItemLongClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnItemLongClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AdapterView.OnItemLongClickListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.AdapterView.OnItemLongClickListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.OnItemLongClickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.OnItemLongClickListenerDelegateWrapper.staticClass, global::android.widget.AdapterView.OnItemLongClickListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnItemLongClickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemLongClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView_OnItemLongClickListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnItemLongClickListenerDelegateWrapper
		{
			private OnItemLongClickListenerDelegate myDelegate;
			public bool onItemLongClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3)
			{
				return myDelegate(arg0, arg1, arg2, arg3);
			}
			public static implicit operator OnItemLongClickListenerDelegateWrapper(OnItemLongClickListenerDelegate d)
			{
				global::android.widget.AdapterView.OnItemLongClickListenerDelegateWrapper ret = new global::android.widget.AdapterView.OnItemLongClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AdapterView.OnItemSelectedListener_))]
		public partial interface OnItemSelectedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onItemSelected(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);
			void onNothingSelected(android.widget.AdapterView arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AdapterView.OnItemSelectedListener))]
		internal sealed partial class OnItemSelectedListener_ : java.lang.Object, OnItemSelectedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnItemSelectedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.AdapterView.OnItemSelectedListener.onItemSelected(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.OnItemSelectedListener_.staticClass, "onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", ref global::android.widget.AdapterView.OnItemSelectedListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.widget.AdapterView.OnItemSelectedListener.onNothingSelected(android.widget.AdapterView arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.OnItemSelectedListener_.staticClass, "onNothingSelected", "(Landroid/widget/AdapterView;)V", ref global::android.widget.AdapterView.OnItemSelectedListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnItemSelectedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AdapterView.OnItemSelectedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView$OnItemSelectedListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AdapterView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.widget.AdapterView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.AdapterView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void addView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;)V", ref global::android.widget.AdapterView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void addView(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;I)V", ref global::android.widget.AdapterView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.AdapterView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void removeView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "removeView", "(Landroid/view/View;)V", ref global::android.widget.AdapterView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void setOnClickListener(android.view.View.OnClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V", ref global::android.widget.AdapterView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnClickListener(global::android.view.View.OnClickListenerDelegate arg0)
		{
			setOnClickListener((global::android.view.View.OnClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setFocusable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "setFocusable", "(Z)V", ref global::android.widget.AdapterView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setFocusableInTouchMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "setFocusableInTouchMode", "(Z)V", ref global::android.widget.AdapterView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.widget.AdapterView._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.widget.AdapterView._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.AdapterView._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AdapterView.staticClass, "getCount", "()I", ref global::android.widget.AdapterView._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override void removeViewAt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "removeViewAt", "(I)V", ref global::android.widget.AdapterView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void removeAllViews()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "removeAllViews", "()V", ref global::android.widget.AdapterView._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected override bool canAnimate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AdapterView.staticClass, "canAnimate", "()Z", ref global::android.widget.AdapterView._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract void setAdapter(android.widget.Adapter arg0);
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", ref global::android.widget.AdapterView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", ref global::android.widget.AdapterView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnItemClickListener(global::android.widget.AdapterView.OnItemClickListenerDelegate arg0)
		{
			setOnItemClickListener((global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::android.widget.AdapterView.OnItemClickListener getOnItemClickListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemClickListener>(this, global::android.widget.AdapterView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", ref global::android.widget.AdapterView._m19) as android.widget.AdapterView.OnItemClickListener;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool performItemClick(android.view.View arg0, int arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AdapterView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z", ref global::android.widget.AdapterView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setOnItemLongClickListener(android.widget.AdapterView.OnItemLongClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V", ref global::android.widget.AdapterView._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnItemLongClickListener(global::android.widget.AdapterView.OnItemLongClickListenerDelegate arg0)
		{
			setOnItemLongClickListener((global::android.widget.AdapterView.OnItemLongClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::android.widget.AdapterView.OnItemLongClickListener getOnItemLongClickListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemLongClickListener>(this, global::android.widget.AdapterView.staticClass, "getOnItemLongClickListener", "()Landroid/widget/AdapterView$OnItemLongClickListener;", ref global::android.widget.AdapterView._m22) as android.widget.AdapterView.OnItemLongClickListener;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.AdapterView.OnItemSelectedListener>(this, global::android.widget.AdapterView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", ref global::android.widget.AdapterView._m23) as android.widget.AdapterView.OnItemSelectedListener;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::android.widget.Adapter getAdapter();
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int getSelectedItemPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AdapterView.staticClass, "getSelectedItemPosition", "()I", ref global::android.widget.AdapterView._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual long getSelectedItemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.AdapterView.staticClass, "getSelectedItemId", "()J", ref global::android.widget.AdapterView._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public abstract global::android.view.View getSelectedView();
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::java.lang.Object getSelectedItem()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AdapterView.staticClass, "getSelectedItem", "()Ljava/lang/Object;", ref global::android.widget.AdapterView._m28) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual int getPositionForView(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AdapterView.staticClass, "getPositionForView", "(Landroid/view/View;)I", ref global::android.widget.AdapterView._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual int getFirstVisiblePosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AdapterView.staticClass, "getFirstVisiblePosition", "()I", ref global::android.widget.AdapterView._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual int getLastVisiblePosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AdapterView.staticClass, "getLastVisiblePosition", "()I", ref global::android.widget.AdapterView._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public abstract void setSelection(int arg0);
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setEmptyView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView.staticClass, "setEmptyView", "(Landroid/view/View;)V", ref global::android.widget.AdapterView._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::android.view.View getEmptyView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AdapterView.staticClass, "getEmptyView", "()Landroid/view/View;", ref global::android.widget.AdapterView._m34) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.lang.Object getItemAtPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AdapterView.staticClass, "getItemAtPosition", "(I)Ljava/lang/Object;", ref global::android.widget.AdapterView._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual long getItemIdAtPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.AdapterView.staticClass, "getItemIdAtPosition", "(I)J", ref global::android.widget.AdapterView._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AdapterView._m37.native == global::System.IntPtr.Zero)
				global::android.widget.AdapterView._m37 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AdapterView._m38.native == global::System.IntPtr.Zero)
				global::android.widget.AdapterView._m38 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public AdapterView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AdapterView._m39.native == global::System.IntPtr.Zero)
				global::android.widget.AdapterView._m39 = @__env.GetMethodIDNoThrow(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int ITEM_VIEW_TYPE_IGNORE
		{
			get
			{
				return -1;
			}
		}
		public static int ITEM_VIEW_TYPE_HEADER_OR_FOOTER
		{
			get
			{
				return -2;
			}
		}
		public static int INVALID_POSITION
		{
			get
			{
				return -1;
			}
		}
		public static long INVALID_ROW_ID
		{
			get
			{
				return -9223372036854775808L;
			}
		}
		static AdapterView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AdapterView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AdapterView))]
	internal sealed partial class AdapterView_ : android.widget.AdapterView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AdapterView_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setAdapter(android.widget.Adapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView_.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V", ref global::android.widget.AdapterView_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::android.widget.Adapter getAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.Adapter>(this, global::android.widget.AdapterView_.staticClass, "getAdapter", "()Landroid/widget/Adapter;", ref global::android.widget.AdapterView_._m1) as android.widget.Adapter;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.view.View getSelectedView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AdapterView_.staticClass, "getSelectedView", "()Landroid/view/View;", ref global::android.widget.AdapterView_._m2) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AdapterView_.staticClass, "setSelection", "(I)V", ref global::android.widget.AdapterView_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AdapterView_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AdapterView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AdapterView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
