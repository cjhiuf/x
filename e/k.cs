/**
 * @description 用户信息
 * @author BEJSON.com
 * @date 2026-07-18
 */
@Data
public class UserInfo implements Serializable {

    private static final long serialVersionUID = 1L;

    @TableId(type = IdType.AUTO)
    /**
    * 用户编号
    */
    private Integer userId;

    /**
    * 用户名
    */
    private String userName;

    /**
    * 状态
    */
    private Integer status;

    /**
    * 创建时间
    */
    private Date createTime;

    public UserInfo() {}
}
