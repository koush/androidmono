namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ExpandableListView : android.widget.ListView
	{
		internal new static global::java.lang.Class staticClass;
		static ExpandableListView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ExpandableListView(@__env);
			}
		}
		protected ExpandableListView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class ExpandableListContextMenuInfo : java.lang.Object, android.view.ContextMenu_ContextMenuInfo
		{
			internal static global::java.lang.Class staticClass;
			static ExpandableListContextMenuInfo()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ExpandableListView.ExpandableListContextMenuInfo(@__env);
				}
			}
			protected ExpandableListContextMenuInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _ExpandableListContextMenuInfo10852;
			public ExpandableListContextMenuInfo(android.view.View arg0, long arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo10852, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.FieldId _targetView10853;
			public global::android.view.View targetView
			{
				get
				{
					return default(global::android.view.View);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _packedPosition10854;
			public long packedPosition
			{
				get
				{
					return default(long);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _id10855;
			public long id
			{
				get
				{
					return default(long);
				}
				set
				{
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass = @__class;
				global::android.widget.ExpandableListView.ExpandableListContextMenuInfo._ExpandableListContextMenuInfo10852 = @__env.GetMethodID(global::android.widget.ExpandableListView.ExpandableListContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;JJ)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnChildClickListener 
		{
			bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4);
		}

		public partial class OnChildClickListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnChildClickListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnChildClickListener : java.lang.Object, OnChildClickListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnChildClickListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView.__OnChildClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ExpandableListView.__OnChildClickListener(@__env);
				}
			}
			internal __OnChildClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onChildClick10856;
			 bool android.widget.ExpandableListView.OnChildClickListener.onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView.__OnChildClickListener._onChildClick10856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.__OnChildClickListener.staticClass, global::android.widget.ExpandableListView.__OnChildClickListener._onChildClick10856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ExpandableListView.__OnChildClickListener.staticClass = @__class;
				global::android.widget.ExpandableListView.__OnChildClickListener._onChildClick10856 = @__env.GetMethodID(global::android.widget.ExpandableListView.__OnChildClickListener.staticClass, "android.widget.ExpandableListView.OnChildClickListener.onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnGroupClickListener 
		{
			bool onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3);
		}

		public partial class OnGroupClickListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnGroupClickListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnGroupClickListener : java.lang.Object, OnGroupClickListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnGroupClickListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView.__OnGroupClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ExpandableListView.__OnGroupClickListener(@__env);
				}
			}
			internal __OnGroupClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGroupClick10857;
			 bool android.widget.ExpandableListView.OnGroupClickListener.onGroupClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView.__OnGroupClickListener._onGroupClick10857, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.__OnGroupClickListener.staticClass, global::android.widget.ExpandableListView.__OnGroupClickListener._onGroupClick10857, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ExpandableListView.__OnGroupClickListener.staticClass = @__class;
				global::android.widget.ExpandableListView.__OnGroupClickListener._onGroupClick10857 = @__env.GetMethodID(global::android.widget.ExpandableListView.__OnGroupClickListener.staticClass, "android.widget.ExpandableListView.OnGroupClickListener.onGroupClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IJ)Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnGroupCollapseListener 
		{
			void onGroupCollapse(int arg0);
		}

		public partial class OnGroupCollapseListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnGroupCollapseListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnGroupCollapseListener : java.lang.Object, OnGroupCollapseListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnGroupCollapseListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView.__OnGroupCollapseListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ExpandableListView.__OnGroupCollapseListener(@__env);
				}
			}
			internal __OnGroupCollapseListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapse10858;
			 void android.widget.ExpandableListView.OnGroupCollapseListener.onGroupCollapse(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.ExpandableListView.__OnGroupCollapseListener._onGroupCollapse10858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.__OnGroupCollapseListener.staticClass, global::android.widget.ExpandableListView.__OnGroupCollapseListener._onGroupCollapse10858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ExpandableListView.__OnGroupCollapseListener.staticClass = @__class;
				global::android.widget.ExpandableListView.__OnGroupCollapseListener._onGroupCollapse10858 = @__env.GetMethodID(global::android.widget.ExpandableListView.__OnGroupCollapseListener.staticClass, "android.widget.ExpandableListView.OnGroupCollapseListener.onGroupCollapse", "(I)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnGroupExpandListener 
		{
			void onGroupExpand(int arg0);
		}

		public partial class OnGroupExpandListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnGroupExpandListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnGroupExpandListener : java.lang.Object, OnGroupExpandListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnGroupExpandListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ExpandableListView.__OnGroupExpandListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ExpandableListView.__OnGroupExpandListener(@__env);
				}
			}
			internal __OnGroupExpandListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGroupExpand10859;
			 void android.widget.ExpandableListView.OnGroupExpandListener.onGroupExpand(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.ExpandableListView.__OnGroupExpandListener._onGroupExpand10859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.__OnGroupExpandListener.staticClass, global::android.widget.ExpandableListView.__OnGroupExpandListener._onGroupExpand10859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ExpandableListView.__OnGroupExpandListener.staticClass = @__class;
				global::android.widget.ExpandableListView.__OnGroupExpandListener._onGroupExpand10859 = @__env.GetMethodID(global::android.widget.ExpandableListView.__OnGroupExpandListener.staticClass, "android.widget.ExpandableListView.OnGroupExpandListener.onGroupExpand", "(I)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState10860;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._onRestoreInstanceState10860, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._onRestoreInstanceState10860, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState10861;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ExpandableListView._onSaveInstanceState10861));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._onSaveInstanceState10861));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw10862;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._dispatchDraw10862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._dispatchDraw10862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10863;
		public override void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setAdapter10863, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setAdapter10863, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10864;
		public virtual void setAdapter(android.widget.ExpandableListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setAdapter10864, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setAdapter10864, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener10865;
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setOnItemClickListener10865, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnItemClickListener10865, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performItemClick10866;
		public override bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView._performItemClick10866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._performItemClick10866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter10867;
		public virtual new global::android.widget.ListAdapter getAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ExpandableListView._getAdapter10867));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getAdapter10867));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListAdapter10868;
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ExpandableListView._getExpandableListAdapter10868));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getExpandableListAdapter10868));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedId10869;
		public virtual long getSelectedId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.ExpandableListView._getSelectedId10869);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getSelectedId10869);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedPosition10870;
		public virtual long getSelectedPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.ExpandableListView._getSelectedPosition10870);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getSelectedPosition10870);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedChild10871;
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView._setSelectedChild10871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setSelectedChild10871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedGroup10872;
		public virtual void setSelectedGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setSelectedGroup10872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setSelectedGroup10872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChildDivider10873;
		public virtual void setChildDivider(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setChildDivider10873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildDivider10873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _expandGroup10874;
		public virtual bool expandGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView._expandGroup10874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._expandGroup10874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _collapseGroup10875;
		public virtual bool collapseGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView._collapseGroup10875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._collapseGroup10875, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnGroupCollapseListener10876;
		public virtual void setOnGroupCollapseListener(android.widget.ExpandableListView.OnGroupCollapseListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setOnGroupCollapseListener10876, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupCollapseListener10876, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnGroupExpandListener10877;
		public virtual void setOnGroupExpandListener(android.widget.ExpandableListView.OnGroupExpandListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setOnGroupExpandListener10877, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupExpandListener10877, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnGroupClickListener10878;
		public virtual void setOnGroupClickListener(android.widget.ExpandableListView.OnGroupClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setOnGroupClickListener10878, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnGroupClickListener10878, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnChildClickListener10879;
		public virtual void setOnChildClickListener(android.widget.ExpandableListView.OnChildClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setOnChildClickListener10879, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setOnChildClickListener10879, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListPosition10880;
		public virtual long getExpandableListPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.ExpandableListView._getExpandableListPosition10880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getExpandableListPosition10880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFlatListPosition10881;
		public virtual int getFlatListPosition(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ExpandableListView._getFlatListPosition10881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getFlatListPosition10881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isGroupExpanded10882;
		public virtual bool isGroupExpanded(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ExpandableListView._isGroupExpanded10882, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._isGroupExpanded10882, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionType10883;
		public static int getPackedPositionType(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionType10883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionGroup10884;
		public static int getPackedPositionGroup(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionGroup10884, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionChild10885;
		public static int getPackedPositionChild(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionChild10885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionForChild10886;
		public static long getPackedPositionForChild(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionForChild10886, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackedPositionForGroup10887;
		public static long getPackedPositionForGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._getPackedPositionForGroup10887, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChildIndicator10888;
		public virtual void setChildIndicator(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setChildIndicator10888, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildIndicator10888, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChildIndicatorBounds10889;
		public virtual void setChildIndicatorBounds(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setChildIndicatorBounds10889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setChildIndicatorBounds10889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupIndicator10890;
		public virtual void setGroupIndicator(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setGroupIndicator10890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setGroupIndicator10890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIndicatorBounds10891;
		public virtual void setIndicatorBounds(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ExpandableListView._setIndicatorBounds10891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._setIndicatorBounds10891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListView10892;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView10892, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListView10893;
		public ExpandableListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView10893, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListView10894;
		public ExpandableListView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ExpandableListView.staticClass, global::android.widget.ExpandableListView._ExpandableListView10894, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ExpandableListView.staticClass = @__class;
			global::android.widget.ExpandableListView._onRestoreInstanceState10860 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ExpandableListView._onSaveInstanceState10861 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ExpandableListView._dispatchDraw10862 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ExpandableListView._setAdapter10863 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.ExpandableListView._setAdapter10864 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setAdapter", "(Landroid/widget/ExpandableListAdapter;)V");
			global::android.widget.ExpandableListView._setOnItemClickListener10865 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.ExpandableListView._performItemClick10866 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.ExpandableListView._getAdapter10867 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.ExpandableListView._getExpandableListAdapter10868 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;");
			global::android.widget.ExpandableListView._getSelectedId10869 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getSelectedId", "()J");
			global::android.widget.ExpandableListView._getSelectedPosition10870 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getSelectedPosition", "()J");
			global::android.widget.ExpandableListView._setSelectedChild10871 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setSelectedChild", "(IIZ)Z");
			global::android.widget.ExpandableListView._setSelectedGroup10872 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setSelectedGroup", "(I)V");
			global::android.widget.ExpandableListView._setChildDivider10873 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setChildDivider", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._expandGroup10874 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "expandGroup", "(I)Z");
			global::android.widget.ExpandableListView._collapseGroup10875 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "collapseGroup", "(I)Z");
			global::android.widget.ExpandableListView._setOnGroupCollapseListener10876 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnGroupCollapseListener", "(Landroid/widget/ExpandableListView$OnGroupCollapseListener;)V");
			global::android.widget.ExpandableListView._setOnGroupExpandListener10877 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnGroupExpandListener", "(Landroid/widget/ExpandableListView$OnGroupExpandListener;)V");
			global::android.widget.ExpandableListView._setOnGroupClickListener10878 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnGroupClickListener", "(Landroid/widget/ExpandableListView$OnGroupClickListener;)V");
			global::android.widget.ExpandableListView._setOnChildClickListener10879 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setOnChildClickListener", "(Landroid/widget/ExpandableListView$OnChildClickListener;)V");
			global::android.widget.ExpandableListView._getExpandableListPosition10880 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getExpandableListPosition", "(I)J");
			global::android.widget.ExpandableListView._getFlatListPosition10881 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "getFlatListPosition", "(J)I");
			global::android.widget.ExpandableListView._isGroupExpanded10882 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "isGroupExpanded", "(I)Z");
			global::android.widget.ExpandableListView._getPackedPositionType10883 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionType", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionGroup10884 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionGroup", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionChild10885 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionChild", "(J)I");
			global::android.widget.ExpandableListView._getPackedPositionForChild10886 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForChild", "(II)J");
			global::android.widget.ExpandableListView._getPackedPositionForGroup10887 = @__env.GetStaticMethodID(global::android.widget.ExpandableListView.staticClass, "getPackedPositionForGroup", "(I)J");
			global::android.widget.ExpandableListView._setChildIndicator10888 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setChildIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._setChildIndicatorBounds10889 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setChildIndicatorBounds", "(II)V");
			global::android.widget.ExpandableListView._setGroupIndicator10890 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setGroupIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ExpandableListView._setIndicatorBounds10891 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "setIndicatorBounds", "(II)V");
			global::android.widget.ExpandableListView._ExpandableListView10892 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ExpandableListView._ExpandableListView10893 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ExpandableListView._ExpandableListView10894 = @__env.GetMethodID(global::android.widget.ExpandableListView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
