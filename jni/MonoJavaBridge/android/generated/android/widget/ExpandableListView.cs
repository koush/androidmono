namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExpandableListView : android.widget.ListView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExpandableListView()
		{
			InitJNI();
		}
		protected ExpandableListView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ExpandableListContextMenuInfo : java.lang.Object, android.view.ContextMenu_ContextMenuInfo
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ExpandableListContextMenuInfo()
			{
				InitJNI();
			}
			protected ExpandableListContextMenuInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ExpandableListContextMenuInfo17022;
			public ExpandableListContextMenuInfo(android.view.View arg0, long arg1, long arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo17022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _targetView17023;
			public global::android.view.View targetView
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _targetView17023)) as android.view.View;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _packedPosition17024;
			public long packedPosition
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _packedPosition17024);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _id17025;
			public long id
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _id17025);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$ExpandableListContextMenuInfo"));
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo17022 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;JJ)V");
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._targetView17023 = @__env.GetFieldIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "targetView", "Landroid/view/View;");
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._packedPosition17024 = @__env.GetFieldIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "packedPosition", "J");
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._id17025 = @__env.GetFieldIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "id", "J");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnChildClickListener_))]
		public partial interface OnChildClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnChildClickListener))]
		internal sealed partial class OnChildClickListener_ : java.lang.Object, OnChildClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnChildClickListener_()
			{
				InitJNI();
			}
			internal OnChildClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onChildClick17026;
			 bool android.widget.ExpandableListView.OnChildClickListener.onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnChildClickListener_._onChildClick17026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnChildClickListener_.staticClass, global::android.widget.ExpandableListView.OnChildClickListener_._onChildClick17026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnChildClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnChildClickListener"));
				global::android.widget.ExpandableListView.OnChildClickListener_._onChildClick17026 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnChildClickListener_.staticClass, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z");
			}
		}

		public delegate bool OnChildClickListenerDelegate(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4);

		internal partial class OnChildClickListenerDelegateWrapper : java.lang.Object, OnChildClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnChildClickListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnChildClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnChildClickListenerDelegateWrapper17027;
			public OnChildClickListenerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper.staticClass, global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper._OnChildClickListenerDelegateWrapper17027);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView_OnChildClickListenerDelegateWrapper"));
				global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper._OnChildClickListenerDelegateWrapper17027 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnChildClickListenerDelegateWrapper
		{
			private OnChildClickListenerDelegate myDelegate;
			public bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4)
			{
				return myDelegate(arg0, arg1, arg2, arg3, arg4);
			}
			public static implicit operator OnChildClickListenerDelegateWrapper(OnChildClickListenerDelegate d)
			{
				global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper ret = new global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupClickListener_))]
		public partial interface OnGroupClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupClickListener))]
		internal sealed partial class OnGroupClickListener_ : java.lang.Object, OnGroupClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupClickListener_()
			{
				InitJNI();
			}
			internal OnGroupClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGroupClick17028;
			 bool android.widget.ExpandableListView.OnGroupClickListener.onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupClickListener_._onGroupClick17028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass, global::android.widget.ExpandableListView.OnGroupClickListener_._onGroupClick17028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupClickListener"));
				global::android.widget.ExpandableListView.OnGroupClickListener_._onGroupClick17028 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass, "onGroupClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IJ)Z");
			}
		}

		public delegate bool OnGroupClickListenerDelegate(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3);

		internal partial class OnGroupClickListenerDelegateWrapper : java.lang.Object, OnGroupClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupClickListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnGroupClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnGroupClickListenerDelegateWrapper17029;
			public OnGroupClickListenerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper.staticClass, global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper._OnGroupClickListenerDelegateWrapper17029);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView_OnGroupClickListenerDelegateWrapper"));
				global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper._OnGroupClickListenerDelegateWrapper17029 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnGroupClickListenerDelegateWrapper
		{
			private OnGroupClickListenerDelegate myDelegate;
			public bool onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3)
			{
				return myDelegate(arg0, arg1, arg2, arg3);
			}
			public static implicit operator OnGroupClickListenerDelegateWrapper(OnGroupClickListenerDelegate d)
			{
				global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper ret = new global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupCollapseListener_))]
		public partial interface OnGroupCollapseListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGroupCollapse(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupCollapseListener))]
		internal sealed partial class OnGroupCollapseListener_ : java.lang.Object, OnGroupCollapseListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupCollapseListener_()
			{
				InitJNI();
			}
			internal OnGroupCollapseListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGroupCollapse17030;
			 void android.widget.ExpandableListView.OnGroupCollapseListener.onGroupCollapse(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupCollapseListener_._onGroupCollapse17030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass, global::android.widget.ExpandableListView.OnGroupCollapseListener_._onGroupCollapse17030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupCollapseListener"));
				global::android.widget.ExpandableListView.OnGroupCollapseListener_._onGroupCollapse17030 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass, "onGroupCollapse", "(I)V");
			}
		}

		public delegate void OnGroupCollapseListenerDelegate(int arg0);

		internal partial class OnGroupCollapseListenerDelegateWrapper : java.lang.Object, OnGroupCollapseListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupCollapseListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnGroupCollapseListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnGroupCollapseListenerDelegateWrapper17031;
			public OnGroupCollapseListenerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper.staticClass, global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper._OnGroupCollapseListenerDelegateWrapper17031);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView_OnGroupCollapseListenerDelegateWrapper"));
				global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper._OnGroupCollapseListenerDelegateWrapper17031 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnGroupCollapseListenerDelegateWrapper
		{
			private OnGroupCollapseListenerDelegate myDelegate;
			public void onGroupCollapse(int arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnGroupCollapseListenerDelegateWrapper(OnGroupCollapseListenerDelegate d)
			{
				global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper ret = new global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupExpandListener_))]
		public partial interface OnGroupExpandListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGroupExpand(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupExpandListener))]
		internal sealed partial class OnGroupExpandListener_ : java.lang.Object, OnGroupExpandListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupExpandListener_()
			{
				InitJNI();
			}
			internal OnGroupExpandListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGroupExpand17032;
			 void android.widget.ExpandableListView.OnGroupExpandListener.onGroupExpand(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupExpandListener_._onGroupExpand17032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass, global::android.widget.ExpandableListView.OnGroupExpandListener_._onGroupExpand17032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupExpandListener"));
				global::android.widget.ExpandableListView.OnGroupExpandListener_._onGroupExpand17032 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass, "onGroupExpand", "(I)V");
			}
		}

		public delegate void OnGroupExpandListenerDelegate(int arg0);

		internal partial class OnGroupExpandListenerDelegateWrapper : java.lang.Object, OnGroupExpandListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupExpandListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnGroupExpandListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnGroupExpandListenerDelegateWrapper17033;
			public OnGroupExpandListenerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper.staticClass, global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper._OnGroupExpandListenerDelegateWrapper17033);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView_OnGroupExpandListenerDelegateWrapper"));
				global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper._OnGroupExpandListenerDelegateWrapper17033 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnGroupExpandListenerDelegateWrapper
		{
			private OnGroupExpandListenerDelegate myDelegate;
			public void onGroupExpand(int arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnGroupExpandListenerDelegateWrapper(OnGroupExpandListenerDelegate d)
			{
				global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper ret = new global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState17034;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._onRestoreInstanceState17034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._onRestoreInstanceState17034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState17035;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView._onSaveInstanceState17035)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._onSaveInstanceState17035)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw17036;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._dispatchDraw17036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._dispatchDraw17036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter17037;
		public override void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setAdapter17037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setAdapter17037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter17038;
		public virtual void setAdapter(android.widget.ExpandableListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setAdapter17038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setAdapter17038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemClickListener17039;
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnItemClickListener17039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnItemClickListener17039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnItemClickListener(global::android.widget.AdapterView.OnItemClickListenerDelegate arg0)
		{
			setOnItemClickListener((global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _performItemClick17040;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._performItemClick17040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._performItemClick17040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.widget.ListAdapter Adapter
		{
			get
			{
				return getAdapter();
			}
			set
			{
				setAdapter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter17041;
		public virtual global::android.widget.ListAdapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView._getAdapter17041)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getAdapter17041)) as android.widget.ListAdapter;
		}
		public new global::android.widget.ExpandableListAdapter ExpandableListAdapter
		{
			get
			{
				return getExpandableListAdapter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExpandableListAdapter17042;
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ExpandableListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView._getExpandableListAdapter17042)) as android.widget.ExpandableListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ExpandableListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getExpandableListAdapter17042)) as android.widget.ExpandableListAdapter;
		}
		public new long SelectedId
		{
			get
			{
				return getSelectedId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedId17043;
		public virtual long getSelectedId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListView._getSelectedId17043);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getSelectedId17043);
		}
		public new long SelectedPosition
		{
			get
			{
				return getSelectedPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedPosition17044;
		public virtual long getSelectedPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListView._getSelectedPosition17044);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getSelectedPosition17044);
		}
		internal static global::MonoJavaBridge.MethodId _setSelectedChild17045;
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._setSelectedChild17045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setSelectedChild17045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setSelectedGroup17046;
		public virtual void setSelectedGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setSelectedGroup17046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setSelectedGroup17046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildDivider17047;
		public virtual void setChildDivider(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setChildDivider17047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildDivider17047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _expandGroup17048;
		public virtual bool expandGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._expandGroup17048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._expandGroup17048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _collapseGroup17049;
		public virtual bool collapseGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._collapseGroup17049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._collapseGroup17049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnGroupCollapseListener17050;
		public virtual void setOnGroupCollapseListener(android.widget.ExpandableListView.OnGroupCollapseListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnGroupCollapseListener17050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupCollapseListener17050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnGroupCollapseListener(global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegate arg0)
		{
			setOnGroupCollapseListener((global::android.widget.ExpandableListView.OnGroupCollapseListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnGroupExpandListener17051;
		public virtual void setOnGroupExpandListener(android.widget.ExpandableListView.OnGroupExpandListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnGroupExpandListener17051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupExpandListener17051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnGroupExpandListener(global::android.widget.ExpandableListView.OnGroupExpandListenerDelegate arg0)
		{
			setOnGroupExpandListener((global::android.widget.ExpandableListView.OnGroupExpandListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnGroupClickListener17052;
		public virtual void setOnGroupClickListener(android.widget.ExpandableListView.OnGroupClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnGroupClickListener17052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupClickListener17052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnGroupClickListener(global::android.widget.ExpandableListView.OnGroupClickListenerDelegate arg0)
		{
			setOnGroupClickListener((global::android.widget.ExpandableListView.OnGroupClickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnChildClickListener17053;
		public virtual void setOnChildClickListener(android.widget.ExpandableListView.OnChildClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnChildClickListener17053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnChildClickListener17053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnChildClickListener(global::android.widget.ExpandableListView.OnChildClickListenerDelegate arg0)
		{
			setOnChildClickListener((global::android.widget.ExpandableListView.OnChildClickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getExpandableListPosition17054;
		public virtual long getExpandableListPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListView._getExpandableListPosition17054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getExpandableListPosition17054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFlatListPosition17055;
		public virtual int getFlatListPosition(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ExpandableListView._getFlatListPosition17055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getFlatListPosition17055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isGroupExpanded17056;
		public virtual bool isGroupExpanded(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._isGroupExpanded17056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._isGroupExpanded17056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionType17057;
		public static int getPackedPositionType(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionType17057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionGroup17058;
		public static int getPackedPositionGroup(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionGroup17058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionChild17059;
		public static int getPackedPositionChild(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionChild17059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionForChild17060;
		public static long getPackedPositionForChild(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionForChild17060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionForGroup17061;
		public static long getPackedPositionForGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionForGroup17061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildIndicator17062;
		public virtual void setChildIndicator(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setChildIndicator17062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildIndicator17062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildIndicatorBounds17063;
		public virtual void setChildIndicatorBounds(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setChildIndicatorBounds17063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildIndicatorBounds17063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupIndicator17064;
		public virtual void setGroupIndicator(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setGroupIndicator17064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setGroupIndicator17064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndicatorBounds17065;
		public virtual void setIndicatorBounds(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setIndicatorBounds17065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setIndicatorBounds17065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListView17066;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView17066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListView17067;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView17067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListView17068;
		public ExpandableListView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView17068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int PACKED_POSITION_TYPE_GROUP
		{
			get
			{
				return 0;
			}
		}
		public static int PACKED_POSITION_TYPE_CHILD
		{
			get
			{
				return 1;
			}
		}
		public static int PACKED_POSITION_TYPE_NULL
		{
			get
			{
				return 2;
			}
		}
		public static long PACKED_POSITION_VALUE_NULL
		{
			get
			{
				return 4294967295L;
			}
		}
		public static int CHILD_INDICATOR_INHERIT
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ExpandableListView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView"));
			global::android.widget.ExpandableListView._onRestoreInstanceState17034 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ExpandableListView._onSaveInstanceState17035 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ExpandableListView._dispatchDraw17036 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ExpandableListView._setAdapter17037 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.ExpandableListView._setAdapter17038 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ExpandableListAdapter;)V");
			global::android.widget.ExpandableListView._setOnItemClickListener17039 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.ExpandableListView._performItemClick17040 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.ExpandableListView._getAdapter17041 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.ExpandableListView._getExpandableListAdapter17042 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;");
			global::android.widget.ExpandableListView._getSelectedId17043 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getSelectedId", "()J");
			global::android.widget.ExpandableListView._getSelectedPosition17044 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getSelectedPosition", "()J");
			global::android.widget.ExpandableListView._setSelectedChild17045 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setSelectedChild", "(IIZ)Z");
			global::android.widget.ExpandableListView._setSelectedGroup17046 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setSelectedGroup", "(I)V");
			global::android.widget.ExpandableListView._setChildDivider17047 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setChildDivider", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._expandGroup17048 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "expandGroup", "(I)Z");
			global::android.widget.ExpandableListView._collapseGroup17049 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "collapseGroup", "(I)Z");
			global::android.widget.ExpandableListView._setOnGroupCollapseListener17050 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnGroupCollapseListener", "(Landroid/widget/ExpandableListView$OnGroupCollapseListener;)V");
			global::android.widget.ExpandableListView._setOnGroupExpandListener17051 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnGroupExpandListener", "(Landroid/widget/ExpandableListView$OnGroupExpandListener;)V");
			global::android.widget.ExpandableListView._setOnGroupClickListener17052 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnGroupClickListener", "(Landroid/widget/ExpandableListView$OnGroupClickListener;)V");
			global::android.widget.ExpandableListView._setOnChildClickListener17053 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnChildClickListener", "(Landroid/widget/ExpandableListView$OnChildClickListener;)V");
			global::android.widget.ExpandableListView._getExpandableListPosition17054 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getExpandableListPosition", "(I)J");
			global::android.widget.ExpandableListView._getFlatListPosition17055 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getFlatListPosition", "(J)I");
			global::android.widget.ExpandableListView._isGroupExpanded17056 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "isGroupExpanded", "(I)Z");
			global::android.widget.ExpandableListView._getPackedPositionType17057 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionType", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionGroup17058 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionGroup", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionChild17059 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionChild", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionForChild17060 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForChild", "(II)J");
			global::android.widget.ExpandableListView._getPackedPositionForGroup17061 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForGroup", "(I)J");
			global::android.widget.ExpandableListView._setChildIndicator17062 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setChildIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._setChildIndicatorBounds17063 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setChildIndicatorBounds", "(II)V");
			global::android.widget.ExpandableListView._setGroupIndicator17064 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setGroupIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._setIndicatorBounds17065 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setIndicatorBounds", "(II)V");
			global::android.widget.ExpandableListView._ExpandableListView17066 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ExpandableListView._ExpandableListView17067 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ExpandableListView._ExpandableListView17068 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
