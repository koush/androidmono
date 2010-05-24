namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AdapterView : android.view.ViewGroup
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AdapterView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AdapterView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AdapterView.AdapterContextMenuInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _AdapterContextMenuInfo9800; 
			public AdapterContextMenuInfo(android.view.View arg0, int arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.AdapterView.AdapterContextMenuInfo.staticClass, _AdapterContextMenuInfo9800, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _targetView9801; 
			public android.view.View targetView
			{ 
				get 
				{ 
					return default(android.view.View); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _position9802; 
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
			internal static global::net.sf.jni4net.jni.FieldId _id9803; 
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
				global::android.widget.AdapterView.AdapterContextMenuInfo._AdapterContextMenuInfo9800 = @__env.GetMethodID(global::android.widget.AdapterView.AdapterContextMenuInfo.staticClass, "<init>", "(Landroid/view/View;IJ)V"); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AdapterView.__OnItemClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _onItemClick9804; 
			 void android.widget.AdapterView.OnItemClickListener.onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.AdapterView.__OnItemClickListener)) 
					@__env.CallVoidMethod(this, _onItemClick9804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.__OnItemClickListener.staticClass, _onItemClick9804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.AdapterView.__OnItemClickListener.staticClass = @__class; 
				global::android.widget.AdapterView.__OnItemClickListener._onItemClick9804 = @__env.GetMethodID(global::android.widget.AdapterView.__OnItemClickListener.staticClass, "android.widget.AdapterView.OnItemClickListener.onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V"); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AdapterView.__OnItemLongClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _onItemLongClick9805; 
			 bool android.widget.AdapterView.OnItemLongClickListener.onItemLongClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.AdapterView.__OnItemLongClickListener)) 
					return @__env.CallBooleanMethod(this, _onItemLongClick9805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.widget.AdapterView.__OnItemLongClickListener.staticClass, _onItemLongClick9805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.AdapterView.__OnItemLongClickListener.staticClass = @__class; 
				global::android.widget.AdapterView.__OnItemLongClickListener._onItemLongClick9805 = @__env.GetMethodID(global::android.widget.AdapterView.__OnItemLongClickListener.staticClass, "android.widget.AdapterView.OnItemLongClickListener.onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z"); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.AdapterView.__OnItemSelectedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _onItemSelected9806; 
			 void android.widget.AdapterView.OnItemSelectedListener.onItemSelected(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.AdapterView.__OnItemSelectedListener)) 
					@__env.CallVoidMethod(this, _onItemSelected9806, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.__OnItemSelectedListener.staticClass, _onItemSelected9806, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onNothingSelected9807; 
			 void android.widget.AdapterView.OnItemSelectedListener.onNothingSelected(android.widget.AdapterView arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.AdapterView.__OnItemSelectedListener)) 
					@__env.CallVoidMethod(this, _onNothingSelected9807, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.__OnItemSelectedListener.staticClass, _onNothingSelected9807, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.AdapterView.__OnItemSelectedListener.staticClass = @__class; 
				global::android.widget.AdapterView.__OnItemSelectedListener._onItemSelected9806 = @__env.GetMethodID(global::android.widget.AdapterView.__OnItemSelectedListener.staticClass, "android.widget.AdapterView.OnItemSelectedListener.onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V"); 
				global::android.widget.AdapterView.__OnItemSelectedListener._onNothingSelected9807 = @__env.GetMethodID(global::android.widget.AdapterView.__OnItemSelectedListener.staticClass, "android.widget.AdapterView.OnItemSelectedListener.onNothingSelected", "(Landroid/widget/AdapterView;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent9808; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent9808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AdapterView.staticClass, _dispatchPopulateAccessibilityEvent9808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9809; 
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _addView9809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _addView9809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9810; 
		public override void addView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _addView9810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _addView9810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9811; 
		public override void addView(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _addView9811, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _addView9811, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9812; 
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _addView9812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _addView9812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeView9813; 
		public override void removeView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _removeView9813, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _removeView9813, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnClickListener9814; 
		public override void setOnClickListener(android.view.View.OnClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setOnClickListener9814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setOnClickListener9814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable9815; 
		public override void setFocusable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setFocusable9815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setFocusable9815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusableInTouchMode9816; 
		public override void setFocusableInTouchMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setFocusableInTouchMode9816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setFocusableInTouchMode9816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState9817; 
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _dispatchSaveInstanceState9817, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _dispatchSaveInstanceState9817, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState9818; 
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _dispatchRestoreInstanceState9818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _dispatchRestoreInstanceState9818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9819; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _onLayout9819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _onLayout9819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount9820; 
		public virtual int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallIntMethod(this, _getCount9820); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AdapterView.staticClass, _getCount9820); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewAt9821; 
		public override void removeViewAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _removeViewAt9821, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _removeViewAt9821, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews9822; 
		public override void removeAllViews() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _removeAllViews9822); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _removeAllViews9822); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canAnimate9823; 
		protected override bool canAnimate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallBooleanMethod(this, _canAnimate9823); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AdapterView.staticClass, _canAnimate9823); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter9824; 
		public abstract void setAdapter(android.widget.Adapter arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemSelectedListener9825; 
		public virtual void setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setOnItemSelectedListener9825, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setOnItemSelectedListener9825, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener9826; 
		public virtual void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setOnItemClickListener9826, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setOnItemClickListener9826, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemClickListener9827; 
		public virtual android.widget.AdapterView.OnItemClickListener getOnItemClickListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnItemClickListener9827)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getOnItemClickListener9827)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performItemClick9828; 
		public virtual bool performItemClick(android.view.View arg0, int arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallBooleanMethod(this, _performItemClick9828, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.AdapterView.staticClass, _performItemClick9828, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemLongClickListener9829; 
		public virtual void setOnItemLongClickListener(android.widget.AdapterView.OnItemLongClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setOnItemLongClickListener9829, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setOnItemLongClickListener9829, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemLongClickListener9830; 
		public virtual android.widget.AdapterView.OnItemLongClickListener getOnItemLongClickListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemLongClickListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnItemLongClickListener9830)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemLongClickListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getOnItemLongClickListener9830)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOnItemSelectedListener9831; 
		public virtual android.widget.AdapterView.OnItemSelectedListener getOnItemSelectedListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallObjectMethodPtr(this, _getOnItemSelectedListener9831)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.AdapterView.OnItemSelectedListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getOnItemSelectedListener9831)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter9832; 
		public abstract android.widget.Adapter getAdapter(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItemPosition9833; 
		public virtual int getSelectedItemPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallIntMethod(this, _getSelectedItemPosition9833); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AdapterView.staticClass, _getSelectedItemPosition9833); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItemId9834; 
		public virtual long getSelectedItemId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallLongMethod(this, _getSelectedItemId9834); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.AdapterView.staticClass, _getSelectedItemId9834); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedView9835; 
		public abstract android.view.View getSelectedView(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedItem9836; 
		public virtual java.lang.Object getSelectedItem() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getSelectedItem9836)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getSelectedItem9836)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionForView9837; 
		public virtual int getPositionForView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallIntMethod(this, _getPositionForView9837, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AdapterView.staticClass, _getPositionForView9837, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFirstVisiblePosition9838; 
		public virtual int getFirstVisiblePosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallIntMethod(this, _getFirstVisiblePosition9838); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AdapterView.staticClass, _getFirstVisiblePosition9838); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLastVisiblePosition9839; 
		public virtual int getLastVisiblePosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallIntMethod(this, _getLastVisiblePosition9839); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.AdapterView.staticClass, _getLastVisiblePosition9839); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9840; 
		public abstract void setSelection(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setEmptyView9841; 
		public virtual void setEmptyView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				@__env.CallVoidMethod(this, _setEmptyView9841, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.AdapterView.staticClass, _setEmptyView9841, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEmptyView9842; 
		public virtual android.view.View getEmptyView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getEmptyView9842)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getEmptyView9842)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemAtPosition9843; 
		public virtual java.lang.Object getItemAtPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getItemAtPosition9843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.AdapterView.staticClass, _getItemAtPosition9843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemIdAtPosition9844; 
		public virtual long getItemIdAtPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.AdapterView)) 
				return @__env.CallLongMethod(this, _getItemIdAtPosition9844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.AdapterView.staticClass, _getItemIdAtPosition9844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AdapterView9845; 
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AdapterView.staticClass, _AdapterView9845, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AdapterView9846; 
		public AdapterView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AdapterView.staticClass, _AdapterView9846, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AdapterView9847; 
		public AdapterView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.AdapterView.staticClass, _AdapterView9847, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.widget.AdapterView._dispatchPopulateAccessibilityEvent9808 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.widget.AdapterView._addView9809 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.AdapterView._addView9810 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;)V"); 
			global::android.widget.AdapterView._addView9811 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;I)V"); 
			global::android.widget.AdapterView._addView9812 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.AdapterView._removeView9813 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "removeView", "(Landroid/view/View;)V"); 
			global::android.widget.AdapterView._setOnClickListener9814 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V"); 
			global::android.widget.AdapterView._setFocusable9815 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setFocusable", "(Z)V"); 
			global::android.widget.AdapterView._setFocusableInTouchMode9816 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setFocusableInTouchMode", "(Z)V"); 
			global::android.widget.AdapterView._dispatchSaveInstanceState9817 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.widget.AdapterView._dispatchRestoreInstanceState9818 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.widget.AdapterView._onLayout9819 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.AdapterView._getCount9820 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getCount", "()I"); 
			global::android.widget.AdapterView._removeViewAt9821 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "removeViewAt", "(I)V"); 
			global::android.widget.AdapterView._removeAllViews9822 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "removeAllViews", "()V"); 
			global::android.widget.AdapterView._canAnimate9823 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "canAnimate", "()Z"); 
			global::android.widget.AdapterView._setAdapter9824 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V"); 
			global::android.widget.AdapterView._setOnItemSelectedListener9825 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V"); 
			global::android.widget.AdapterView._setOnItemClickListener9826 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V"); 
			global::android.widget.AdapterView._getOnItemClickListener9827 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;"); 
			global::android.widget.AdapterView._performItemClick9828 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "performItemClick", "(Landroid/view/View;IJ)Z"); 
			global::android.widget.AdapterView._setOnItemLongClickListener9829 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V"); 
			global::android.widget.AdapterView._getOnItemLongClickListener9830 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getOnItemLongClickListener", "()Landroid/widget/AdapterView$OnItemLongClickListener;"); 
			global::android.widget.AdapterView._getOnItemSelectedListener9831 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;"); 
			global::android.widget.AdapterView._getAdapter9832 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getAdapter", "()Landroid/widget/Adapter;"); 
			global::android.widget.AdapterView._getSelectedItemPosition9833 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedItemPosition", "()I"); 
			global::android.widget.AdapterView._getSelectedItemId9834 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedItemId", "()J"); 
			global::android.widget.AdapterView._getSelectedView9835 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedView", "()Landroid/view/View;"); 
			global::android.widget.AdapterView._getSelectedItem9836 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getSelectedItem", "()Ljava/lang/Object;"); 
			global::android.widget.AdapterView._getPositionForView9837 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getPositionForView", "(Landroid/view/View;)I"); 
			global::android.widget.AdapterView._getFirstVisiblePosition9838 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getFirstVisiblePosition", "()I"); 
			global::android.widget.AdapterView._getLastVisiblePosition9839 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getLastVisiblePosition", "()I"); 
			global::android.widget.AdapterView._setSelection9840 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setSelection", "(I)V"); 
			global::android.widget.AdapterView._setEmptyView9841 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "setEmptyView", "(Landroid/view/View;)V"); 
			global::android.widget.AdapterView._getEmptyView9842 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getEmptyView", "()Landroid/view/View;"); 
			global::android.widget.AdapterView._getItemAtPosition9843 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getItemAtPosition", "(I)Ljava/lang/Object;"); 
			global::android.widget.AdapterView._getItemIdAtPosition9844 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "getItemIdAtPosition", "(I)J"); 
			global::android.widget.AdapterView._AdapterView9845 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.AdapterView._AdapterView9846 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.AdapterView._AdapterView9847 = @__env.GetMethodID(global::android.widget.AdapterView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
