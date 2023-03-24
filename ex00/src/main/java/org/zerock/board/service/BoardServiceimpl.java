package org.zerock.board.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.zerock.board.dao.BoardDAOimpl;

import lombok.Data;
import lombok.Setter;

@Service
@Data
public class BoardServiceimpl {
	
	@Setter(onMethod_ = @Autowired)
	private BoardDAOimpl dao; 
}
