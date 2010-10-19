namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.SortedSet_))]
	public interface SortedSet : Set
	{
		global::java.lang.Object last();
		global::java.lang.Object first();
		global::java.util.Comparator comparator();
		global::java.util.SortedSet subSet(java.lang.Object arg0, java.lang.Object arg1);
		global::java.util.SortedSet headSet(java.lang.Object arg0);
		global::java.util.SortedSet tailSet(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.SortedSet))]
	public sealed partial class SortedSet_ : java.lang.Object, SortedSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SortedSet_()
		{
			InitJNI();
		}
		internal SortedSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _last20835;
		 global::java.lang.Object java.util.SortedSet.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._last20835)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._last20835)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _first20836;
		 global::java.lang.Object java.util.SortedSet.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._first20836)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._first20836)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _comparator20837;
		 global::java.util.Comparator java.util.SortedSet.comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._comparator20837)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._comparator20837)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subSet20838;
		 global::java.util.SortedSet java.util.SortedSet.subSet(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._subSet20838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._subSet20838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _headSet20839;
		 global::java.util.SortedSet java.util.SortedSet.headSet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._headSet20839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._headSet20839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _tailSet20840;
		 global::java.util.SortedSet java.util.SortedSet.tailSet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._tailSet20840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._tailSet20840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _add20841;
		 bool java.util.Set.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._add20841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._add20841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20842;
		 bool java.util.Set.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._equals20842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._equals20842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20843;
		 int java.util.Set.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._hashCode20843);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._hashCode20843);
		}
		internal static global::MonoJavaBridge.MethodId _clear20844;
		 void java.util.Set.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedSet_._clear20844);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._clear20844);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20845;
		 bool java.util.Set.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._isEmpty20845);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._isEmpty20845);
		}
		internal static global::MonoJavaBridge.MethodId _contains20846;
		 bool java.util.Set.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._contains20846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._contains20846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20847;
		 bool java.util.Set.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._addAll20847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._addAll20847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20848;
		 int java.util.Set.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._size20848);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._size20848);
		}
		internal static global::MonoJavaBridge.MethodId _toArray20849;
		 global::java.lang.Object[] java.util.Set.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray20849)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray20849)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray20850;
		 global::java.lang.Object[] java.util.Set.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray20850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray20850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator20851;
		 global::java.util.Iterator java.util.Set.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._iterator20851)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._iterator20851)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20852;
		 bool java.util.Set.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._remove20852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._remove20852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll20853;
		 bool java.util.Set.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._containsAll20853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._containsAll20853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll20854;
		 bool java.util.Set.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._removeAll20854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._removeAll20854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll20855;
		 bool java.util.Set.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._retainAll20855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._retainAll20855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add20856;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._add20856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._add20856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20857;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._equals20857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._equals20857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20858;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._hashCode20858);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._hashCode20858);
		}
		internal static global::MonoJavaBridge.MethodId _clear20859;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedSet_._clear20859);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._clear20859);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20860;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._isEmpty20860);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._isEmpty20860);
		}
		internal static global::MonoJavaBridge.MethodId _contains20861;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._contains20861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._contains20861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20862;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._addAll20862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._addAll20862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20863;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._size20863);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._size20863);
		}
		internal static global::MonoJavaBridge.MethodId _toArray20864;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray20864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray20864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray20865;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray20865)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray20865)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator20866;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._iterator20866)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._iterator20866)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20867;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._remove20867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._remove20867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll20868;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._containsAll20868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._containsAll20868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll20869;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._removeAll20869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._removeAll20869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll20870;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._retainAll20870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._retainAll20870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator20871;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._iterator20871)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._iterator20871)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SortedSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SortedSet"));
			global::java.util.SortedSet_._last20835 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "last", "()Ljava/lang/Object;");
			global::java.util.SortedSet_._first20836 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "first", "()Ljava/lang/Object;");
			global::java.util.SortedSet_._comparator20837 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.SortedSet_._subSet20838 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.SortedSet_._headSet20839 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.SortedSet_._tailSet20840 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.SortedSet_._add20841 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._equals20842 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._hashCode20843 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "hashCode", "()I");
			global::java.util.SortedSet_._clear20844 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "clear", "()V");
			global::java.util.SortedSet_._isEmpty20845 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "isEmpty", "()Z");
			global::java.util.SortedSet_._contains20846 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._addAll20847 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._size20848 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "size", "()I");
			global::java.util.SortedSet_._toArray20849 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.SortedSet_._toArray20850 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.SortedSet_._iterator20851 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.SortedSet_._remove20852 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._containsAll20853 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._removeAll20854 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._retainAll20855 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._add20856 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._equals20857 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._hashCode20858 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "hashCode", "()I");
			global::java.util.SortedSet_._clear20859 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "clear", "()V");
			global::java.util.SortedSet_._isEmpty20860 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "isEmpty", "()Z");
			global::java.util.SortedSet_._contains20861 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._addAll20862 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._size20863 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "size", "()I");
			global::java.util.SortedSet_._toArray20864 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.SortedSet_._toArray20865 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.SortedSet_._iterator20866 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.SortedSet_._remove20867 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._containsAll20868 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._removeAll20869 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._retainAll20870 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._iterator20871 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
