namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class BaseAdapter : java.lang.Object, ListAdapter, SpinnerAdapter
	{ 
		internal static global::java.lang.Class staticClass; 
		static BaseAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.BaseAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected BaseAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount9230; 
		public abstract int getCount(); 
		internal static global::net.sf.jni4net.jni.MethodId _getItem9231; 
		public abstract java.lang.Object getItem(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId9232; 
		public abstract long getItemId(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getView9233; 
		public abstract android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty9234; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				return @__env.CallBooleanMethod(this, _isEmpty9234); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.BaseAdapter.staticClass, _isEmpty9234); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled9235; 
		public virtual bool isEnabled(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				return @__env.CallBooleanMethod(this, _isEnabled9235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.BaseAdapter.staticClass, _isEnabled9235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver9236; 
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				@__env.CallVoidMethod(this, _registerDataSetObserver9236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.BaseAdapter.staticClass, _registerDataSetObserver9236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver9237; 
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				@__env.CallVoidMethod(this, _unregisterDataSetObserver9237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.BaseAdapter.staticClass, _unregisterDataSetObserver9237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled9238; 
		public virtual bool areAllItemsEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				return @__env.CallBooleanMethod(this, _areAllItemsEnabled9238); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.BaseAdapter.staticClass, _areAllItemsEnabled9238); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds9239; 
		public virtual bool hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				return @__env.CallBooleanMethod(this, _hasStableIds9239); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.BaseAdapter.staticClass, _hasStableIds9239); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType9240; 
		public virtual int getItemViewType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				return @__env.CallIntMethod(this, _getItemViewType9240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.BaseAdapter.staticClass, _getItemViewType9240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount9241; 
		public virtual int getViewTypeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				return @__env.CallIntMethod(this, _getViewTypeCount9241); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.BaseAdapter.staticClass, _getViewTypeCount9241); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView9242; 
		public virtual android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getDropDownView9242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.BaseAdapter.staticClass, _getDropDownView9242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged9243; 
		public virtual void notifyDataSetChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				@__env.CallVoidMethod(this, _notifyDataSetChanged9243); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.BaseAdapter.staticClass, _notifyDataSetChanged9243); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetInvalidated9244; 
		public virtual void notifyDataSetInvalidated() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseAdapter)) 
				@__env.CallVoidMethod(this, _notifyDataSetInvalidated9244); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.BaseAdapter.staticClass, _notifyDataSetInvalidated9244); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BaseAdapter9245; 
		public BaseAdapter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.BaseAdapter.staticClass, _BaseAdapter9245, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.BaseAdapter.staticClass = @__class; 
			global::android.widget.BaseAdapter._getCount9230 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getCount", "()I"); 
			global::android.widget.BaseAdapter._getItem9231 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.BaseAdapter._getItemId9232 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getItemId", "(I)J"); 
			global::android.widget.BaseAdapter._getView9233 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.BaseAdapter._isEmpty9234 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "isEmpty", "()Z"); 
			global::android.widget.BaseAdapter._isEnabled9235 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "isEnabled", "(I)Z"); 
			global::android.widget.BaseAdapter._registerDataSetObserver9236 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.BaseAdapter._unregisterDataSetObserver9237 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.BaseAdapter._areAllItemsEnabled9238 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "areAllItemsEnabled", "()Z"); 
			global::android.widget.BaseAdapter._hasStableIds9239 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "hasStableIds", "()Z"); 
			global::android.widget.BaseAdapter._getItemViewType9240 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getItemViewType", "(I)I"); 
			global::android.widget.BaseAdapter._getViewTypeCount9241 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getViewTypeCount", "()I"); 
			global::android.widget.BaseAdapter._getDropDownView9242 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.BaseAdapter._notifyDataSetChanged9243 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "notifyDataSetChanged", "()V"); 
			global::android.widget.BaseAdapter._notifyDataSetInvalidated9244 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "notifyDataSetInvalidated", "()V"); 
			global::android.widget.BaseAdapter._BaseAdapter9245 = @__env.GetMethodID(global::android.widget.BaseAdapter.staticClass, "<init>", "()V"); 
		} 
	} 
} 
