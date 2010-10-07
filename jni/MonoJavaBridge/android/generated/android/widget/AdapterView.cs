namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AdapterView : android.view.ViewGroup
	{
		internal new static global::java.lang.Class staticClass;
		static AdapterView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AdapterView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AdapterView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class AdapterContextMenuInfo : java.lang.Object, android.view.ContextMenu_ContextMenuInfo
		{
			internal static global::java.lang.Class staticClass;
			static AdapterContextMenuInfo()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AdapterView.AdapterContextMenuInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.AdapterView.AdapterContextMenuInfo(@__env);
				}
			}
			protected AdapterContextMenuInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _AdapterContextMenuInfo10497;
			public AdapterContextMenuInfo(android.view.View arg0, int arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.AdapterView.AdapterContextMenuInfo.staticClass, global::android.widget.AdapterView.AdapterContextMenuInfo._AdapterContextMenuInfo10497, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.FieldId _targetView10498;
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
			internal static global::net.sf.jni4net.jni.FieldId _position10499;
			public int position
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _id10500;
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
				global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass = @__class;
				global::android.widget.AdapterView.AdapterContextMenuInfo._AdapterContextMenuInfo10497 = @__env.GetMethodID(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;IJ)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnItemClickListener 
		{
			void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);
		}

		public partial class OnItemClickListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnItemClickListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnItemClickListener : java.lang.Object, OnItemClickListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnItemClickListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AdapterView.__OnItemClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.AdapterView.__OnItemClickListener(@__env);
				}
			}
			internal __OnItemClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onItemClick10501;
			 void android.widget.AdapterView.OnItemClickListener.onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.AdapterView.__OnItemClickListener._onItemClick10501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.__OnItemClickListener.staticClass, global::android.widget.AdapterView.__OnItemClickListener._onItemClick10501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AdapterView.__OnItemClickListener.staticClass = @__class;
				global::android.widget.AdapterView.__OnItemClickListener._onItemClick10501 = @__env.GetMethodID(global::android.widget.AdapterView.__OnItemClickListener.staticClass, "android.widget.AdapterView.OnItemClickListener.onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnItemLongClickListener 
		{
			bool onItemLongClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);
		}

		public partial class OnItemLongClickListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnItemLongClickListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnItemLongClickListener : java.lang.Object, OnItemLongClickListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnItemLongClickListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AdapterView.__OnItemLongClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.AdapterView.__OnItemLongClickListener(@__env);
				}
			}
			internal __OnItemLongClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onItemLongClick10502;
			 bool android.widget.AdapterView.OnItemLongClickListener.onItemLongClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.AdapterView.__OnItemLongClickListener._onItemLongClick10502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AdapterView.__OnItemLongClickListener.staticClass, global::android.widget.AdapterView.__OnItemLongClickListener._onItemLongClick10502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AdapterView.__OnItemLongClickListener.staticClass = @__class;
				global::android.widget.AdapterView.__OnItemLongClickListener._onItemLongClick10502 = @__env.GetMethodID(global::android.widget.AdapterView.__OnItemLongClickListener.staticClass, "android.widget.AdapterView.OnItemLongClickListener.onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnItemSelectedListener 
		{
			void onItemSelected(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3);
			void onNothingSelected(android.widget.AdapterView arg0);
		}

		public partial class OnItemSelectedListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnItemSelectedListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnItemSelectedListener : java.lang.Object, OnItemSelectedListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnItemSelectedListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AdapterView.__OnItemSelectedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.AdapterView.__OnItemSelectedListener(@__env);
				}
			}
			internal __OnItemSelectedListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onItemSelected10503;
			 void android.widget.AdapterView.OnItemSelectedListener.onItemSelected(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.AdapterView.__OnItemSelectedListener._onItemSelected10503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.__OnItemSelectedListener.staticClass, global::android.widget.AdapterView.__OnItemSelectedListener._onItemSelected10503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onNothingSelected10504;
			 void android.widget.AdapterView.OnItemSelectedListener.onNothingSelected(android.widget.AdapterView arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.AdapterView.__OnItemSelectedListener._onNothingSelected10504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.__OnItemSelectedListener.staticClass, global::android.widget.AdapterView.__OnItemSelectedListener._onNothingSelected10504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AdapterView.__OnItemSelectedListener.staticClass = @__class;
				global::android.widget.AdapterView.__OnItemSelectedListener._onItemSelected10503 = @__env.GetMethodID(global::android.widget.AdapterView.__OnItemSelectedListener.staticClass, "android.widget.AdapterView.OnItemSelectedListener.onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
				global::android.widget.AdapterView.__OnItemSelectedListener._onNothingSelected10504 = @__env.GetMethodID(global::android.widget.AdapterView.__OnItemSelectedListener.staticClass, "android.widget.AdapterView.OnItemSelectedListener.onNothingSelected", "(Landroid/widget/AdapterView;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent10505;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent10505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent10505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10506;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._addView10506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView10506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10507;
		public override void addView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._addView10507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView10507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10508;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._addView10508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView10508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10509;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._addView10509, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._addView10509, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeView10510;
		public override void removeView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._removeView10510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._removeView10510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickListener10511;
		public override void setOnClickListener(android.view.View.OnClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._setOnClickListener10511, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnClickListener10511, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable10512;
		public override void setFocusable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._setFocusable10512, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setFocusable10512, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFocusableInTouchMode10513;
		public override void setFocusableInTouchMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._setFocusableInTouchMode10513, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setFocusableInTouchMode10513, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState10514;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._dispatchSaveInstanceState10514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._dispatchSaveInstanceState10514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState10515;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._dispatchRestoreInstanceState10515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._dispatchRestoreInstanceState10515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10516;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._onLayout10516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._onLayout10516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount10517;
		public virtual int getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AdapterView._getCount10517);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getCount10517);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeViewAt10518;
		public override void removeViewAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._removeViewAt10518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._removeViewAt10518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews10519;
		public override void removeAllViews() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._removeAllViews10519);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._removeAllViews10519);
		}
		internal static global::net.sf.jni4net.jni.MethodId _canAnimate10520;
		protected override bool canAnimate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AdapterView._canAnimate10520);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._canAnimate10520);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10521;
		public abstract void setAdapter(android.widget.Adapter arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemSelectedListener10522;
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._setOnItemSelectedListener10522, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnItemSelectedListener10522, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener10523;
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._setOnItemClickListener10523, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnItemClickListener10523, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemClickListener10524;
		public virtual global::android.widget.AdapterView.OnItemClickListener getOnItemClickListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AdapterView._getOnItemClickListener10524));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getOnItemClickListener10524));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performItemClick10525;
		public virtual bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AdapterView._performItemClick10525, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._performItemClick10525, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemLongClickListener10526;
		public virtual void setOnItemLongClickListener(android.widget.AdapterView.OnItemLongClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._setOnItemLongClickListener10526, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setOnItemLongClickListener10526, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemLongClickListener10527;
		public virtual global::android.widget.AdapterView.OnItemLongClickListener getOnItemLongClickListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemLongClickListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AdapterView._getOnItemLongClickListener10527));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemLongClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getOnItemLongClickListener10527));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemSelectedListener10528;
		public virtual global::android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AdapterView._getOnItemSelectedListener10528));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getOnItemSelectedListener10528));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter10529;
		public abstract global::android.widget.Adapter getAdapter();
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItemPosition10530;
		public virtual int getSelectedItemPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AdapterView._getSelectedItemPosition10530);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getSelectedItemPosition10530);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItemId10531;
		public virtual long getSelectedItemId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.AdapterView._getSelectedItemId10531);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getSelectedItemId10531);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedView10532;
		public abstract global::android.view.View getSelectedView();
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItem10533;
		public virtual global::java.lang.Object getSelectedItem() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AdapterView._getSelectedItem10533));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getSelectedItem10533));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPositionForView10534;
		public virtual int getPositionForView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AdapterView._getPositionForView10534, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getPositionForView10534, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFirstVisiblePosition10535;
		public virtual int getFirstVisiblePosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AdapterView._getFirstVisiblePosition10535);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getFirstVisiblePosition10535);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLastVisiblePosition10536;
		public virtual int getLastVisiblePosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AdapterView._getLastVisiblePosition10536);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getLastVisiblePosition10536);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection10537;
		public abstract void setSelection(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setEmptyView10538;
		public virtual void setEmptyView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AdapterView._setEmptyView10538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._setEmptyView10538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEmptyView10539;
		public virtual global::android.view.View getEmptyView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AdapterView._getEmptyView10539));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getEmptyView10539));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemAtPosition10540;
		public virtual global::java.lang.Object getItemAtPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AdapterView._getItemAtPosition10540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getItemAtPosition10540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemIdAtPosition10541;
		public virtual long getItemIdAtPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.AdapterView._getItemIdAtPosition10541, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.AdapterView.staticClass, global::android.widget.AdapterView._getItemIdAtPosition10541, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AdapterView10542;
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._AdapterView10542, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AdapterView10543;
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._AdapterView10543, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AdapterView10544;
		public AdapterView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AdapterView.staticClass, global::android.widget.AdapterView._AdapterView10544, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.AdapterView.staticClass = @__class;
			global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent10505 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.AdapterView._addView10506 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.AdapterView._addView10507 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.AdapterView._addView10508 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.AdapterView._addView10509 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.AdapterView._removeView10510 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.widget.AdapterView._setOnClickListener10511 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.AdapterView._setFocusable10512 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setFocusable", "(Z)V");
			global::android.widget.AdapterView._setFocusableInTouchMode10513 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setFocusableInTouchMode", "(Z)V");
			global::android.widget.AdapterView._dispatchSaveInstanceState10514 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.widget.AdapterView._dispatchRestoreInstanceState10515 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.widget.AdapterView._onLayout10516 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.AdapterView._getCount10517 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getCount", "()I");
			global::android.widget.AdapterView._removeViewAt10518 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "removeViewAt", "(I)V");
			global::android.widget.AdapterView._removeAllViews10519 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "removeAllViews", "()V");
			global::android.widget.AdapterView._canAnimate10520 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "canAnimate", "()Z");
			global::android.widget.AdapterView._setAdapter10521 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AdapterView._setOnItemSelectedListener10522 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V");
			global::android.widget.AdapterView._setOnItemClickListener10523 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.AdapterView._getOnItemClickListener10524 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
			global::android.widget.AdapterView._performItemClick10525 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z");
			global::android.widget.AdapterView._setOnItemLongClickListener10526 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V");
			global::android.widget.AdapterView._getOnItemLongClickListener10527 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getOnItemLongClickListener", "()Landroid/widget/AdapterView$OnItemLongClickListener;");
			global::android.widget.AdapterView._getOnItemSelectedListener10528 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
			global::android.widget.AdapterView._getAdapter10529 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AdapterView._getSelectedItemPosition10530 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedItemPosition", "()I");
			global::android.widget.AdapterView._getSelectedItemId10531 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedItemId", "()J");
			global::android.widget.AdapterView._getSelectedView10532 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AdapterView._getSelectedItem10533 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedItem", "()Ljava/lang/Object;");
			global::android.widget.AdapterView._getPositionForView10534 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getPositionForView", "(Landroid/view/View;)I");
			global::android.widget.AdapterView._getFirstVisiblePosition10535 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getFirstVisiblePosition", "()I");
			global::android.widget.AdapterView._getLastVisiblePosition10536 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getLastVisiblePosition", "()I");
			global::android.widget.AdapterView._setSelection10537 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setSelection", "(I)V");
			global::android.widget.AdapterView._setEmptyView10538 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setEmptyView", "(Landroid/view/View;)V");
			global::android.widget.AdapterView._getEmptyView10539 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getEmptyView", "()Landroid/view/View;");
			global::android.widget.AdapterView._getItemAtPosition10540 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getItemAtPosition", "(I)Ljava/lang/Object;");
			global::android.widget.AdapterView._getItemIdAtPosition10541 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getItemIdAtPosition", "(I)J");
			global::android.widget.AdapterView._AdapterView10542 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AdapterView._AdapterView10543 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AdapterView._AdapterView10544 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
