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
			internal static global::MonoJavaBridge.MethodId _ExpandableListContextMenuInfo16925;
			public ExpandableListContextMenuInfo(android.view.View arg0, long arg1, long arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo16925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _targetView16926;
			public global::android.view.View targetView
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _targetView16926)) as android.view.View;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _packedPosition16927;
			public long packedPosition
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _packedPosition16927);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _id16928;
			public long id
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetLongField(this.JvmHandle, _id16928);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$ExpandableListContextMenuInfo"));
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo16925 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;JJ)V");
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._targetView16926 = @__env.GetFieldIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "targetView", "Landroid/view/View;");
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._packedPosition16927 = @__env.GetFieldIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "packedPosition", "J");
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._id16928 = @__env.GetFieldIDNoThrow(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "id", "J");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnChildClickListener_))]
		public partial interface OnChildClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnChildClickListener))]
		public sealed partial class OnChildClickListener_ : java.lang.Object, OnChildClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnChildClickListener_()
			{
				InitJNI();
			}
			internal OnChildClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onChildClick16929;
			 bool android.widget.ExpandableListView.OnChildClickListener.onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnChildClickListener_._onChildClick16929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnChildClickListener_.staticClass, global::android.widget.ExpandableListView.OnChildClickListener_._onChildClick16929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnChildClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnChildClickListener"));
				global::android.widget.ExpandableListView.OnChildClickListener_._onChildClick16929 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnChildClickListener_.staticClass, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupClickListener_))]
		public partial interface OnGroupClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupClickListener))]
		public sealed partial class OnGroupClickListener_ : java.lang.Object, OnGroupClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupClickListener_()
			{
				InitJNI();
			}
			internal OnGroupClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGroupClick16930;
			 bool android.widget.ExpandableListView.OnGroupClickListener.onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupClickListener_._onGroupClick16930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass, global::android.widget.ExpandableListView.OnGroupClickListener_._onGroupClick16930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupClickListener"));
				global::android.widget.ExpandableListView.OnGroupClickListener_._onGroupClick16930 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupClickListener_.staticClass, "onGroupClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IJ)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupCollapseListener_))]
		public partial interface OnGroupCollapseListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGroupCollapse(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupCollapseListener))]
		public sealed partial class OnGroupCollapseListener_ : java.lang.Object, OnGroupCollapseListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupCollapseListener_()
			{
				InitJNI();
			}
			internal OnGroupCollapseListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGroupCollapse16931;
			 void android.widget.ExpandableListView.OnGroupCollapseListener.onGroupCollapse(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupCollapseListener_._onGroupCollapse16931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass, global::android.widget.ExpandableListView.OnGroupCollapseListener_._onGroupCollapse16931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupCollapseListener"));
				global::android.widget.ExpandableListView.OnGroupCollapseListener_._onGroupCollapse16931 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupCollapseListener_.staticClass, "onGroupCollapse", "(I)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListView.OnGroupExpandListener_))]
		public partial interface OnGroupExpandListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGroupExpand(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListView.OnGroupExpandListener))]
		public sealed partial class OnGroupExpandListener_ : java.lang.Object, OnGroupExpandListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGroupExpandListener_()
			{
				InitJNI();
			}
			internal OnGroupExpandListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGroupExpand16932;
			 void android.widget.ExpandableListView.OnGroupExpandListener.onGroupExpand(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupExpandListener_._onGroupExpand16932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass, global::android.widget.ExpandableListView.OnGroupExpandListener_._onGroupExpand16932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListView$OnGroupExpandListener"));
				global::android.widget.ExpandableListView.OnGroupExpandListener_._onGroupExpand16932 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.OnGroupExpandListener_.staticClass, "onGroupExpand", "(I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState16933;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._onRestoreInstanceState16933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._onRestoreInstanceState16933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState16934;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView._onSaveInstanceState16934)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._onSaveInstanceState16934)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw16935;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._dispatchDraw16935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._dispatchDraw16935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16936;
		public override void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setAdapter16936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setAdapter16936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16937;
		public virtual void setAdapter(android.widget.ExpandableListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setAdapter16937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setAdapter16937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemClickListener16938;
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnItemClickListener16938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnItemClickListener16938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performItemClick16939;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._performItemClick16939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._performItemClick16939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		internal static global::MonoJavaBridge.MethodId _getAdapter16940;
		public virtual global::android.widget.ListAdapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView._getAdapter16940)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getAdapter16940)) as android.widget.ListAdapter;
		}
		public new global::android.widget.ExpandableListAdapter ExpandableListAdapter
		{
			get
			{
				return getExpandableListAdapter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExpandableListAdapter16941;
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ExpandableListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView._getExpandableListAdapter16941)) as android.widget.ExpandableListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ExpandableListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getExpandableListAdapter16941)) as android.widget.ExpandableListAdapter;
		}
		public new long SelectedId
		{
			get
			{
				return getSelectedId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedId16942;
		public virtual long getSelectedId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListView._getSelectedId16942);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getSelectedId16942);
		}
		public new long SelectedPosition
		{
			get
			{
				return getSelectedPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedPosition16943;
		public virtual long getSelectedPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListView._getSelectedPosition16943);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getSelectedPosition16943);
		}
		internal static global::MonoJavaBridge.MethodId _setSelectedChild16944;
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._setSelectedChild16944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setSelectedChild16944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setSelectedGroup16945;
		public virtual void setSelectedGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setSelectedGroup16945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setSelectedGroup16945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildDivider16946;
		public virtual void setChildDivider(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setChildDivider16946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildDivider16946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _expandGroup16947;
		public virtual bool expandGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._expandGroup16947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._expandGroup16947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _collapseGroup16948;
		public virtual bool collapseGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._collapseGroup16948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._collapseGroup16948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnGroupCollapseListener16949;
		public virtual void setOnGroupCollapseListener(android.widget.ExpandableListView.OnGroupCollapseListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnGroupCollapseListener16949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupCollapseListener16949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnGroupExpandListener16950;
		public virtual void setOnGroupExpandListener(android.widget.ExpandableListView.OnGroupExpandListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnGroupExpandListener16950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupExpandListener16950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnGroupClickListener16951;
		public virtual void setOnGroupClickListener(android.widget.ExpandableListView.OnGroupClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnGroupClickListener16951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupClickListener16951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnChildClickListener16952;
		public virtual void setOnChildClickListener(android.widget.ExpandableListView.OnChildClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setOnChildClickListener16952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnChildClickListener16952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExpandableListPosition16953;
		public virtual long getExpandableListPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListView._getExpandableListPosition16953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getExpandableListPosition16953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFlatListPosition16954;
		public virtual int getFlatListPosition(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ExpandableListView._getFlatListPosition16954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getFlatListPosition16954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isGroupExpanded16955;
		public virtual bool isGroupExpanded(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView._isGroupExpanded16955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._isGroupExpanded16955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionType16956;
		public static int getPackedPositionType(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionType16956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionGroup16957;
		public static int getPackedPositionGroup(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionGroup16957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionChild16958;
		public static int getPackedPositionChild(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionChild16958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionForChild16959;
		public static long getPackedPositionForChild(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionForChild16959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackedPositionForGroup16960;
		public static long getPackedPositionForGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionForGroup16960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildIndicator16961;
		public virtual void setChildIndicator(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setChildIndicator16961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildIndicator16961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildIndicatorBounds16962;
		public virtual void setChildIndicatorBounds(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setChildIndicatorBounds16962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildIndicatorBounds16962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupIndicator16963;
		public virtual void setGroupIndicator(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setGroupIndicator16963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setGroupIndicator16963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndicatorBounds16964;
		public virtual void setIndicatorBounds(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView._setIndicatorBounds16964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setIndicatorBounds16964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListView16965;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView16965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListView16966;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView16966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExpandableListView16967;
		public ExpandableListView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView16967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.widget.ExpandableListView._onRestoreInstanceState16933 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ExpandableListView._onSaveInstanceState16934 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ExpandableListView._dispatchDraw16935 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ExpandableListView._setAdapter16936 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.ExpandableListView._setAdapter16937 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ExpandableListAdapter;)V");
			global::android.widget.ExpandableListView._setOnItemClickListener16938 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.ExpandableListView._performItemClick16939 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.ExpandableListView._getAdapter16940 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.ExpandableListView._getExpandableListAdapter16941 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;");
			global::android.widget.ExpandableListView._getSelectedId16942 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getSelectedId", "()J");
			global::android.widget.ExpandableListView._getSelectedPosition16943 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getSelectedPosition", "()J");
			global::android.widget.ExpandableListView._setSelectedChild16944 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setSelectedChild", "(IIZ)Z");
			global::android.widget.ExpandableListView._setSelectedGroup16945 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setSelectedGroup", "(I)V");
			global::android.widget.ExpandableListView._setChildDivider16946 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setChildDivider", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._expandGroup16947 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "expandGroup", "(I)Z");
			global::android.widget.ExpandableListView._collapseGroup16948 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "collapseGroup", "(I)Z");
			global::android.widget.ExpandableListView._setOnGroupCollapseListener16949 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnGroupCollapseListener", "(Landroid/widget/ExpandableListView$OnGroupCollapseListener;)V");
			global::android.widget.ExpandableListView._setOnGroupExpandListener16950 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnGroupExpandListener", "(Landroid/widget/ExpandableListView$OnGroupExpandListener;)V");
			global::android.widget.ExpandableListView._setOnGroupClickListener16951 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnGroupClickListener", "(Landroid/widget/ExpandableListView$OnGroupClickListener;)V");
			global::android.widget.ExpandableListView._setOnChildClickListener16952 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setOnChildClickListener", "(Landroid/widget/ExpandableListView$OnChildClickListener;)V");
			global::android.widget.ExpandableListView._getExpandableListPosition16953 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getExpandableListPosition", "(I)J");
			global::android.widget.ExpandableListView._getFlatListPosition16954 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getFlatListPosition", "(J)I");
			global::android.widget.ExpandableListView._isGroupExpanded16955 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "isGroupExpanded", "(I)Z");
			global::android.widget.ExpandableListView._getPackedPositionType16956 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionType", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionGroup16957 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionGroup", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionChild16958 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionChild", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionForChild16959 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForChild", "(II)J");
			global::android.widget.ExpandableListView._getPackedPositionForGroup16960 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForGroup", "(I)J");
			global::android.widget.ExpandableListView._setChildIndicator16961 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setChildIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._setChildIndicatorBounds16962 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setChildIndicatorBounds", "(II)V");
			global::android.widget.ExpandableListView._setGroupIndicator16963 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setGroupIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._setIndicatorBounds16964 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "setIndicatorBounds", "(II)V");
			global::android.widget.ExpandableListView._ExpandableListView16965 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ExpandableListView._ExpandableListView16966 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ExpandableListView._ExpandableListView16967 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
